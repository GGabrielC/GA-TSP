using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Travelling_Salesman.Dependencies
{
    public static class ExtensionMethodsCollections
    {
        public static Element MaxElement<Element>(this ICollection<Element> container,
                                                   Func<Element, float> function)
        {
            var bestElement = container.First();
            foreach (var specimen in container)
            {
                var score = function(specimen);
                var bestScore = function(bestElement);
                if (bestScore.CompareTo(score) < 0)
                    bestElement = specimen;
            }
            return bestElement;
        }

        public static string MyToString<T>(this ICollection<T> collection)
        {
            var output = "[ ";
            foreach (var el in collection)
                output += el.ToString() + ", ";
            return output + "]";
        }

        public static void Shuffle<T>(this List<T> list, Random random)
        {
            int index;

            for (var i = 0; i < list.Count; i++)
            {
                index = random.Next(0, list.Count);
                T aux = list[i];
                list[i] = list[index];
                list[index] = aux;
            }
        }

        public static int BinarySearchIndexInterval(this List<float> list, float value)
        {
            var left = 0;
            var right = list.Count - 1;
            if (left == right) return left;

            int mid;
            while (left + 1 != right)
            {
                mid = (left + right) / 2;
                var midValue = list[mid];
                var comparisson = value.ECompareTo(midValue);

                if (comparisson > 0)
                    left = mid;
                else if (comparisson < 0)
                    right = mid;
                else return mid;
            }

            if (value.ECompareTo(list[left]) <= 0)
                return left;
            return right;
        }

        public static List<float> getCumulativeSumList(this ICollection<float> elements)
        {
            var cumulativeSum = new List<float>(elements.Count);
            var prevSum = default(float);
            foreach (var element in elements)
            {
                var sum = prevSum + element;
                cumulativeSum.Add(sum);
                prevSum = sum;
            }
            return cumulativeSum;
        }

        public static ICollection<float> GetProbabilitiesToPick(this ICollection<float> scores, float scoreDiscrimination = 2)
        {
            // making scores > 1
            var numbers = scores.Select(el => el).ToList();
            var minNumber = scores.Min();
            if (minNumber < 1)
            {
                var shift = 1 + Math.Abs(minNumber);
                numbers = scores.Select(el => el + shift).ToList();
            }
            // scaling the numbers to a maximum 
            var maxNumber = numbers.Max();
            var maxReasonableExponent = 20;
            numbers = numbers.Select(el => el * maxReasonableExponent / maxNumber).ToList();
            // getting new relative scores
            var comparison = maxReasonableExponent;
            numbers = numbers.Select(el => (float)Math.Pow(scoreDiscrimination, 1 + el) / comparison).ToList();
            // scaling new scores between 0 and 1
            var sum = numbers.Sum();
            var probabilities = numbers.Select(el => el / sum);
            return probabilities.ToList();
        }

    }
}


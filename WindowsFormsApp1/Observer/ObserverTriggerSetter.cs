using GA_Travelling_Salesman.Observer;
using GA_Travelling_Salesman.Travelling_Salesman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Observers;
using WindowsFormsApp1.Travelling_Salesman;

namespace WindowsFormsApp1.Observer
{
    public class ObserverTriggerSetter
    { 

        delegate void ChangeText();

        public static void SetTriggers(ObserverMulti observer, FormMain formMain)
        {
            Action<ToolStripMenuItem, string> setTextToolStripMenuItem = (ToolStripMenuItem item, string text) =>
            {
                if (formMain.InvokeRequired)
                {
                    var setTextDelegate = new ChangeText(() =>
                    {
                        item.Text = text;
                    });
                    formMain.Invoke(setTextDelegate, new object[] { });
                }
                else item.Text = text;
            };

            Action<Label, string> setTextLabel = (Label item, string text) =>
             {
                 if (formMain.InvokeRequired)
                 {
                     var setTextDelegate = new ChangeText(() =>
                     {
                         item.Text = text;
                     });
                     formMain.Invoke(setTextDelegate, new object[] { });
                 }
                 else item.Text = text;
             };

            observer.AddTrigger(StateChanged.newGeneration, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelCurrentGenerationValue, subjectGA.CurrentGeneration + "/" + subjectGA.ExpectedGenerationCount);
            });

            observer.AddTrigger(StateChanged.ExpectedGenerationCount, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelCurrentGenerationValue, subjectGA.CurrentGeneration + "/" + subjectGA.ExpectedGenerationCount);
            });

            observer.AddTrigger(StateChanged.BestSolution, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelBestShortestPathValue, subjectGA.BestSolution.Distance.ToString());
            });

            observer.AddTrigger(StateChanged.LastGenerationBestFitter, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelLastShortestPathValue, subjectGA.LastGenerationBestFitter.Distance.ToString());
            });

            observer.AddTrigger(StateChanged.ExpectedGenerationCount, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelMaxGenerationsValue, subjectGA.ExpectedGenerationCount.ToString());
            });

            observer.AddTrigger(StateChanged.ExepectedMutationRate, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelMutationRateValue, subjectGA.ExpectedMutationRate.ToString());
            });

            observer.AddTrigger(StateChanged.ExpectedPopulationCount, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelPopulationSizeValue, subjectGA.ExpectedPopulationCount.ToString());
            });

            observer.AddTrigger(StateChanged.ExpectedFitnessDiscrimination, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                setTextLabel(formMain.LabelFitnessDiscriminatorValue, subjectGA.ExpectedFitnessDiscrimination.ToString());
            });

            observer.AddTrigger(StateChanged.BestSolution, (subject) =>
            {
                if (!formMain.CheckBoxDrawBestSolution.Checked)
                    return;
                formMain.RedrawBestSolution();
            });
            observer.AddTrigger(StateChanged.ExpectedExecutionStatus, (subject) =>
            {
                GA_TravellingSalesman subjectGA = (GA_TravellingSalesman)subject;
                string text;
                if (subjectGA.IsExecuting)
                    text = "Pause";
                else text = "Run";
                setTextToolStripMenuItem(formMain.ToolStripMenuItem_GaRunStatus, text);
            });

            observer.AddTrigger(StateChanged.ExepectedMutationRate, (subject) =>
            {
                new FormInfo("Mutation Rate changed !").Show();
            });
            observer.AddTrigger(StateChanged.ExpectedGenerationCount, (subject) =>
            {
                new FormInfo("Max. generations changed !").Show();
            });
            observer.AddTrigger(StateChanged.ExpectedPopulationCount, (subject) =>
            {
                new FormInfo("Population count changed !").Show();
            });
            observer.AddTrigger(StateChanged.ExpectedFitnessDiscrimination, (subject) =>
            {
                new FormInfo("Fitness Discrimination changed !").Show();
            });
        }
    }
}

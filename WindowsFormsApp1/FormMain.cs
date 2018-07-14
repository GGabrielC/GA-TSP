using GA_Travelling_Salesman;
using GA_Travelling_Salesman.Observer;
using GA_Travelling_Salesman.Travelling_Salesman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Input;
using WindowsFormsApp1.Observer;
using WindowsFormsApp1.Observers;
using WindowsFormsApp1.Travelling_Salesman;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        volatile ObserverMulti observerGa = null;
        volatile ICollection<Point> input = null;
        volatile GA_TravellingSalesman ga = null;
        volatile Painter bestPathPainter = null;

        public CheckBox CheckBoxDrawBestSolution { get => checkBoxDrawBestSolution; }
        public Label LabelCurrentGenerationValue { get => labelCurrentGenerationValue; }
        public Label LabelBestShortestPathValue { get => labelBestShortestPathValue; }
        public Label LabelLastShortestPathValue { get => labelLastShortestPathValue; }
        public Label LabelMaxGenerationsValue { get => labelMaxGenerationsValue; }
        public Label LabelMutationRateValue { get => labelMutationRateValue; }
        public Label LabelPopulationSizeValue { get => labelPopulationSizeValue; }
        public Label LabelFitnessDiscriminatorValue { get => labelFitnessDiscriminatorValue; }
        public Panel PanelPath { get => panelPath; }
        public ToolStripMenuItem ToolStripMenuItem_GaRunStatus { get => toolStripMenuItem_GaRunStatus; }

        public Painter BestPathPainter { get => bestPathPainter; private set { bestPathPainter = value; } }
        

        delegate void RefreshPanel();
        public void RefreshPanelPath()
        {
            if (PanelPath.InvokeRequired)
            {
                RefreshPanel d = new RefreshPanel(() =>
                {
                    PanelPath.Refresh();
                });
                PanelPath.Invoke(d, new object[] { });
            }
            else PanelPath.Refresh();
        }
    
        public void RedrawBestSolution()
        {
            RefreshPanelPath();
            BestPathPainter?.DrawCircularPath(GA.BestSolution);
        }

        public bool GaStarted { get => GA != null && GA.Started; }
        public bool GaIsRunning { get => GA != null && GA.IsExecuting; }
        
        public void RunGa() => GA.Execute();
        
        public void PauseGA() => GA?.StopExecution();
        
        public ICollection<Point> Input
        {
            get => input;
            set
            {
                input = value;
                RefreshPanelPath();
                if (value == null)
                {
                    this.labelStatus.Text = "No Input";
                    this.ToolStripMenuItem_GaRunStatus.Text = "";
                }
                else
                {
                    PauseGA();
                    GA = new GA_TravellingSalesman(Input);
                    this.labelStatus.Text = "Input Set";
                    this.ToolStripMenuItem_GaRunStatus.Text = "Run";
                    BestPathPainter.DrawPoints(Input);
                }
                checkBoxAddBestToPopulation.Checked = GA_TravellingSalesman.DEFAULT_ADD_BEST_SOLUTION_TO_POPULATION;
            }
        }
        private GA_TravellingSalesman GA
        {
            get => ga;
            set
            {
                if (value == null)
                    PauseGA();
                else ObserverGA = new ObserverMulti(value);

                ga = value;
            }
        }
        private ObserverMulti ObserverGA
        {
            get => observerGa;
            set
            {
                observerGa = value;
                if (value != null)
                    ObserverTriggerSetter.SetTriggers(value, this);
            }
        }
        
        public FormMain()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Input = null;
            GA = null;
            BestPathPainter = new Painter(PanelPath);

            checkBoxAddBestToPopulation.Checked = GA_TravellingSalesman.DEFAULT_ADD_BEST_SOLUTION_TO_POPULATION;
            numericUpDownDiscrimination.Value = (Decimal)GA_TravellingSalesman.DEFAULT_FITNESS_DISCRIMINATION;
            numericUpDownMaxGenerations.Value = GA_TravellingSalesman.DEFAULT_GENERATION_COUNT;
            numericUpDownPopulationSize.Value = GA_TravellingSalesman.DEFAULT_POPULATION_COUNT;
            numericUpDownMutationRate.Value = (Decimal)GA_TravellingSalesman.DEFAULT_MUTATION_RATE;

            this.LabelFitnessDiscriminatorValue.Text = GA_TravellingSalesman.DEFAULT_FITNESS_DISCRIMINATION.ToString();
            this.labelMaxGenerationsValue.Text = GA_TravellingSalesman.DEFAULT_GENERATION_COUNT.ToString();
            this.LabelPopulationSizeValue.Text = GA_TravellingSalesman.DEFAULT_POPULATION_COUNT.ToString();
            this.LabelMutationRateValue.Text = GA_TravellingSalesman.DEFAULT_MUTATION_RATE.ToString();
        }

        private void ToolStripMenuItem_GaRunStatus_Click(object sender, EventArgs e)
        {
            if (GaIsRunning)
                PauseGA();
            else RunGa();
        }

        private void randomInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input = InputGetter.getInputByRandom(GlobalRandom.Instance);
        }
        private void fileInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input = InputGetter.getInputByFile();
        }

        private void numericUpDownMaxGenerations_ValueChanged(object sender, EventArgs e)
        {
            if (GA == null) return;
            Action onSave = () => GA.ExpectedGenerationCount = (int)numericUpDownMaxGenerations.Value;
            new FormConfirmChange(onSave).Show();
        }

        private void numericUpDownDiscrimination_ValueChanged(object sender, EventArgs e)
        {
            if (GA == null) return;
            Action onSave = () => GA.ExpectedFitnessDiscrimination = (float)numericUpDownDiscrimination.Value;
            new FormConfirmChange(onSave).Show();
        }

        private void numericUpDownPopulationSize_ValueChanged(object sender, EventArgs e)
        {
            if (GA == null) return;
            Action onSave = () => GA.ExpectedPopulationCount = (int)numericUpDownPopulationSize.Value;
            new FormConfirmChange(onSave).Show();
        }

        private void numericUpDownMutationRate_ValueChanged(object sender, EventArgs e)
        {
            if (GA == null) return;
            Action onSave = () => GA.ExpectedMutationRate = (float)numericUpDownMutationRate.Value;
            new FormConfirmChange(onSave).Show();
        }

        private void checkBoxAddBestToPopulation_CheckedChanged(object sender, EventArgs e)
        {
            GA.ExpectedAddBestSolutionToPopulation = checkBoxAddBestToPopulation.Checked;
        }

        private void checkBoxDrawBestSolution_CheckedChanged(object sender, EventArgs e)
        {
            RedrawBestSolution();
        }
    }
}

using DataScienceForFunAndProfit;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conditionOnRunnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BuildChart(
                new PredictionEngine(
                    Horse.GetRunnersAndRiders()).ConditionedOnRunners());

        }

        private void BuildChart(List<Probability> probs)
        {
            this.chartControl1.Series.Clear();
            this.chartControl1.DataSource = probs;
            Series series = new Series("ProbabilitySeries", ViewType.Pie)
            {
                LegendTextPattern = "{A}"
                
            };
            series.Label.TextPattern = "{A}: {VP:P2}";
            this.chartControl1.Series.Add(series);
            series.ArgumentDataMember = "HorseName";
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }

        private void conditionOnMileTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BuildChart(
                new PredictionEngine(
                    Horse.GetRunnersAndRiders()).ConditionedOnMileTimes());
        }

        private void conditionOnFinishingPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BuildChart(
                new PredictionEngine(
                    Horse.GetRunnersAndRiders()).ConditionedOnFinishingPosition());
        }

        private void unifiedProbabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BuildChart(
                new PredictionEngine(
                    Horse.GetRunnersAndRiders()).UnifiedProbability());
        }

        private void bayesWinningFromStall6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BuildChart(
                new PredictionEngine(
                    Horse.GetRunnersAndRiders()).BayesProbWinningFromStall6());
        }
    }
}

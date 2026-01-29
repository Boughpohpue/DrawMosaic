using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mosaic
{
    public partial class Form1 : Form
    {
        private Pen _pen;
        private bool _drawingMode = false;
        private bool _useAbsoluteCenter = false;
        private Point _centerPoint = new Point(0, 0);
        private Point _absoluteCenterPoint = new Point(0, 0);
        private Point _lastDrawPoint = new Point(0, 0);
        private Color _penColor = Color.Black;
        private Color _backColor = Color.White;

        private Point _currentCenterPoint => _useAbsoluteCenter ? _absoluteCenterPoint : _centerPoint;

        public Form1()
        {
            InitializeComponent();

            penColorPanel.BackColor = _penColor;
            backColorPanel.BackColor = _backColor;

            _pen = new Pen(_penColor, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulatePenSizeCombo();
            PopulateMosaicLevelCombo();

            _absoluteCenterPoint = new Point(mosaicPanel.Width / 2, mosaicPanel.Height / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            using (var g = mosaicPanel.CreateGraphics())
            {
                g.Clear(mosaicPanel.BackColor);
            }
        }

        private void penColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = penColorPanel.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                penColorPanel.BackColor = colorDialog1.Color;
                _penColor = penColorPanel.BackColor;
                _pen = new Pen(_penColor, GetSelectedPenSize());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _useAbsoluteCenter = checkBox1.Checked;
        }

        private void mosaicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _drawingMode = true;
            _centerPoint = new Point(e.X, e.Y);
            _lastDrawPoint = new Point(e.X, e.Y);
        }

        private void mosaicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _drawingMode = false;
        }

        private void mosaicPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawingMode)
            {
                using (var graphics = mosaicPanel.CreateGraphics())
                {
                    var currentPoint = new Point(e.X, e.Y);

                    graphics.DrawMosaicLines(
                        _pen,
                        _currentCenterPoint,
                        _lastDrawPoint,
                        currentPoint,
                        GetSelectedMosaicLevel());
                }

                Invalidate();

                _lastDrawPoint.X = e.X;
                _lastDrawPoint.Y = e.Y;
            }
        }

        private void penSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pen = new Pen(_penColor, GetSelectedPenSize());
        }

        private void backColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = backColorPanel.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                backColorPanel.BackColor = colorDialog1.Color;
                mosaicPanel.BackColor = colorDialog1.Color;
            }
        }

        private void PopulatePenSizeCombo()
        {
            penSizeComboBox.Items.Clear();
            penSizeComboBox.Items.Add("1");
            penSizeComboBox.Items.Add("2");
            penSizeComboBox.Items.Add("3");
            penSizeComboBox.Items.Add("4");
            penSizeComboBox.Items.Add("5");

            penSizeComboBox.SelectedIndex = 0;
        }

        private void PopulateMosaicLevelCombo()
        {
            mosaicLevelComboBox.Items.Clear();
            mosaicLevelComboBox.Items.Add("None");
            mosaicLevelComboBox.Items.Add("x2 V");
            mosaicLevelComboBox.Items.Add("x2 H");
            mosaicLevelComboBox.Items.Add("x4");
            mosaicLevelComboBox.Items.Add("x8");

            mosaicLevelComboBox.SelectedIndex = mosaicLevelComboBox.Items.Count - 1;
        }

        private int GetSelectedPenSize()
        {
            return int.Parse($"{penSizeComboBox.SelectedItem}");
        }

        private MosaicLevel GetSelectedMosaicLevel()
        {
            return (MosaicLevel)Enum.Parse(
                typeof(MosaicLevel), 
                $"{mosaicLevelComboBox.SelectedItem}"
                    .Replace(" ", "")
                    .ToUpper()
                );
        }
    }
}

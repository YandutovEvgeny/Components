
namespace Components
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.analogClock1 = new Clocks.AnalogClock();
            ((System.ComponentModel.ISupportInitialize)(this.analogClock1)).BeginInit();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.BackGroundClockImage = global::Clocks.Properties.Resources.clocks1;
            this.analogClock1.BackGroundColor = System.Drawing.Color.White;
            this.analogClock1.HourArrowColor = System.Drawing.Color.Green;
            this.analogClock1.HourArrowWidth = 6;
            this.analogClock1.Location = new System.Drawing.Point(13, 13);
            this.analogClock1.MinuteArrowColor = System.Drawing.Color.Red;
            this.analogClock1.MinuteArrowWidth = 4;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondArrowColor = System.Drawing.Color.Blue;
            this.analogClock1.SecondArrowWidth = 2;
            this.analogClock1.Size = new System.Drawing.Size(250, 250);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TabStop = false;
            this.analogClock1.UseImage = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 433);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analogClock1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Clocks.AnalogClock analogClock1;
    }
}



namespace WeatherThinhg
{
    partial class frmWeatherThing
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dewpoint = new System.Windows.Forms.Label();
            this.Clouds = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.Feelslike = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.Sunset = new System.Windows.Forms.Label();
            this.Sunrise = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.Currenttime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMatchQuality = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(454, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(12, 42);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(73, 15);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Feels Like";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pressure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Humidity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Clouds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dew Point";
            // 
            // Dewpoint
            // 
            this.Dewpoint.AutoSize = true;
            this.Dewpoint.Location = new System.Drawing.Point(92, 192);
            this.Dewpoint.Name = "Dewpoint";
            this.Dewpoint.Size = new System.Drawing.Size(37, 15);
            this.Dewpoint.TabIndex = 12;
            this.Dewpoint.Text = "          ";
            // 
            // Clouds
            // 
            this.Clouds.AutoSize = true;
            this.Clouds.Location = new System.Drawing.Point(92, 162);
            this.Clouds.Name = "Clouds";
            this.Clouds.Size = new System.Drawing.Size(37, 15);
            this.Clouds.TabIndex = 11;
            this.Clouds.Text = "          ";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Location = new System.Drawing.Point(92, 132);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(37, 15);
            this.Humidity.TabIndex = 10;
            this.Humidity.Text = "          ";
            this.Humidity.Click += new System.EventHandler(this.Humidity_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Location = new System.Drawing.Point(92, 102);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(37, 15);
            this.Pressure.TabIndex = 9;
            this.Pressure.Text = "          ";
            // 
            // Feelslike
            // 
            this.Feelslike.AutoSize = true;
            this.Feelslike.Location = new System.Drawing.Point(92, 72);
            this.Feelslike.Name = "Feelslike";
            this.Feelslike.Size = new System.Drawing.Size(37, 15);
            this.Feelslike.TabIndex = 8;
            this.Feelslike.Text = "          ";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Location = new System.Drawing.Point(92, 42);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(37, 15);
            this.Temperature.TabIndex = 7;
            this.Temperature.Text = "          ";
            // 
            // Sunset
            // 
            this.Sunset.AutoSize = true;
            this.Sunset.Location = new System.Drawing.Point(92, 252);
            this.Sunset.Name = "Sunset";
            this.Sunset.Size = new System.Drawing.Size(37, 15);
            this.Sunset.TabIndex = 16;
            this.Sunset.Text = "          ";
            // 
            // Sunrise
            // 
            this.Sunrise.AutoSize = true;
            this.Sunrise.Location = new System.Drawing.Point(92, 222);
            this.Sunrise.Name = "Sunrise";
            this.Sunrise.Size = new System.Drawing.Size(37, 15);
            this.Sunrise.TabIndex = 15;
            this.Sunrise.Text = "          ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sunset";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Location = new System.Drawing.Point(12, 222);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(45, 15);
            this.lblSunset.TabIndex = 13;
            this.lblSunset.Text = "Sunrise";
            // 
            // Currenttime
            // 
            this.Currenttime.AutoSize = true;
            this.Currenttime.Location = new System.Drawing.Point(92, 12);
            this.Currenttime.Name = "Currenttime";
            this.Currenttime.Size = new System.Drawing.Size(37, 15);
            this.Currenttime.TabIndex = 18;
            this.Currenttime.Text = "          ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Current time";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.DarkGray;
            this.pbIcon.Location = new System.Drawing.Point(466, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(63, 60);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbIcon.TabIndex = 19;
            this.pbIcon.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Longitutde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Latitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Address";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(92, 320);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(37, 15);
            this.Latitude.TabIndex = 24;
            this.Latitude.Text = "          ";
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(92, 350);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(37, 15);
            this.Longitude.TabIndex = 23;
            this.Longitude.Text = "          ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(92, 279);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 23);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.Text = "seebachstrasse 15 hallstadt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Match Quality";
            // 
            // lblMatchQuality
            // 
            this.lblMatchQuality.AutoSize = true;
            this.lblMatchQuality.Location = new System.Drawing.Point(444, 282);
            this.lblMatchQuality.Name = "lblMatchQuality";
            this.lblMatchQuality.Size = new System.Drawing.Size(0, 15);
            this.lblMatchQuality.TabIndex = 27;
            // 
            // frmWeatherThing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 401);
            this.Controls.Add(this.lblMatchQuality);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.Currenttime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Sunset);
            this.Controls.Add(this.Sunrise);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.Dewpoint);
            this.Controls.Add(this.Clouds);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Feelslike);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmWeatherThing";
            this.Text = "Weather Thing";
            this.Load += new System.EventHandler(this.frmWeatherThing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Dewpoint;
        private System.Windows.Forms.Label Clouds;
        private System.Windows.Forms.Label Humidity;
        private System.Windows.Forms.Label Pressure;
        private System.Windows.Forms.Label Feelslike;
        private System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Label Sunset;
        private System.Windows.Forms.Label Sunrise;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label Currenttime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMatchQuality;
    }
}


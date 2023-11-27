
namespace HomePage
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.txtPlantAmount = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblPlantAmount = new System.Windows.Forms.Label();
            this.lblPlantID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtPlantID = new System.Windows.Forms.TextBox();
            this.rbtnPending = new System.Windows.Forms.RadioButton();
            this.rbtnInProcess = new System.Windows.Forms.RadioButton();
            this.rbtnDelivered = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(126, 78);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(70, 20);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(233, 78);
            this.txtOrderID.Multiline = true;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(220, 20);
            this.txtOrderID.TabIndex = 4;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(96, 138);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(100, 20);
            this.lblOrderStatus.TabIndex = 5;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // txtPlantAmount
            // 
            this.txtPlantAmount.Location = new System.Drawing.Point(233, 301);
            this.txtPlantAmount.Multiline = true;
            this.txtPlantAmount.Name = "txtPlantAmount";
            this.txtPlantAmount.Size = new System.Drawing.Size(220, 20);
            this.txtPlantAmount.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(233, 362);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(220, 20);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(233, 192);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(220, 20);
            this.txtCustomerID.TabIndex = 8;
            // 
            // lblPlantAmount
            // 
            this.lblPlantAmount.AutoSize = true;
            this.lblPlantAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantAmount.Location = new System.Drawing.Point(91, 299);
            this.lblPlantAmount.Name = "lblPlantAmount";
            this.lblPlantAmount.Size = new System.Drawing.Size(105, 20);
            this.lblPlantAmount.TabIndex = 10;
            this.lblPlantAmount.Text = "Plant Amount";
            this.lblPlantAmount.Click += new System.EventHandler(this.lblPlantAmount_Click);
            // 
            // lblPlantID
            // 
            this.lblPlantID.AutoSize = true;
            this.lblPlantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlantID.Location = new System.Drawing.Point(130, 246);
            this.lblPlantID.Name = "lblPlantID";
            this.lblPlantID.Size = new System.Drawing.Size(66, 20);
            this.lblPlantID.TabIndex = 11;
            this.lblPlantID.Text = "Plant ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer ID";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(91, 362);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.lblTotalPrice.TabIndex = 13;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // txtPlantID
            // 
            this.txtPlantID.Location = new System.Drawing.Point(233, 248);
            this.txtPlantID.Multiline = true;
            this.txtPlantID.Name = "txtPlantID";
            this.txtPlantID.Size = new System.Drawing.Size(220, 20);
            this.txtPlantID.TabIndex = 14;
            // 
            // rbtnPending
            // 
            this.rbtnPending.AutoSize = true;
            this.rbtnPending.Location = new System.Drawing.Point(233, 138);
            this.rbtnPending.Name = "rbtnPending";
            this.rbtnPending.Size = new System.Drawing.Size(64, 17);
            this.rbtnPending.TabIndex = 19;
            this.rbtnPending.TabStop = true;
            this.rbtnPending.Text = "Pending";
            this.rbtnPending.UseVisualStyleBackColor = true;
            // 
            // rbtnInProcess
            // 
            this.rbtnInProcess.AutoSize = true;
            this.rbtnInProcess.Location = new System.Drawing.Point(319, 138);
            this.rbtnInProcess.Name = "rbtnInProcess";
            this.rbtnInProcess.Size = new System.Drawing.Size(75, 17);
            this.rbtnInProcess.TabIndex = 20;
            this.rbtnInProcess.TabStop = true;
            this.rbtnInProcess.Text = "In Process";
            this.rbtnInProcess.UseVisualStyleBackColor = true;
            // 
            // rbtnDelivered
            // 
            this.rbtnDelivered.AutoSize = true;
            this.rbtnDelivered.Location = new System.Drawing.Point(410, 138);
            this.rbtnDelivered.Name = "rbtnDelivered";
            this.rbtnDelivered.Size = new System.Drawing.Size(70, 17);
            this.rbtnDelivered.TabIndex = 21;
            this.rbtnDelivered.TabStop = true;
            this.rbtnDelivered.Text = "Delivered";
            this.rbtnDelivered.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(121, 415);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(222, 415);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 27;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(319, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbtnDelivered);
            this.Controls.Add(this.rbtnInProcess);
            this.Controls.Add(this.rbtnPending);
            this.Controls.Add(this.txtPlantID);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlantID);
            this.Controls.Add(this.lblPlantAmount);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtPlantAmount);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.TextBox txtPlantAmount;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblPlantAmount;
        private System.Windows.Forms.Label lblPlantID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtPlantID;
        private System.Windows.Forms.RadioButton rbtnPending;
        private System.Windows.Forms.RadioButton rbtnInProcess;
        private System.Windows.Forms.RadioButton rbtnDelivered;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
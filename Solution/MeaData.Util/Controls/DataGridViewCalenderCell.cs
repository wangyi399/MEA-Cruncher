﻿using System;
using System.Windows.Forms;

namespace MeaData.Util.Controls {

    public class DataGridViewCalendarCell : DataGridViewTextBoxCell {
        // CONSTRUCTORS
        public DataGridViewCalendarCell() : base() {
            // Use the short date format.
            this.Style.Format = "d";
        }

        // PROPERTIES
        public override Type EditType {
            get {
                // Return the type of the editing contol that CalendarCell uses.
                return typeof(CalendarEditingControl);
            }
        }
        public override Type ValueType {
            get {
                // Return the type of the value that CalendarCell contains.
                return typeof(DateTime);
            }
        }
        public override object DefaultNewRowValue {
            get {
                // Use the current date and time as the default value.
                return DateTime.Now;
            }
        }

        // FUNCTIONS
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle) {
            // Set the value of the editing control to the current cell value.
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            CalendarEditingControl ctl =
                DataGridView.EditingControl as CalendarEditingControl;
            ctl.Value = (DateTime)this.Value;
        }
    }
    
}
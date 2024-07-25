using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Internal;

namespace WinFormsApp1
{
    public class FilterComboBox : Guna2ComboBox
    {
        private string _placeholderText;
        private List<string> _originalItems = new List<string>();

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
                UpdatePlaceholder();
            }
        }

        public FilterComboBox()
        {
            this.DropDownStyle = ComboBoxStyle.DropDown; // Make it editable
            this.ForeColor = Color.Gray;
            this.TextChanged += FilterComboBox_TextChanged;
            this.Leave += FilterComboBox_Leave;
            this.Enter += FilterComboBox_Enter;
            this.DropDown += FilterComboBox_DropDown;
        }

        private void UpdatePlaceholder()
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                this.Text = _placeholderText;
                this.ForeColor = Color.Gray;
            }
        }

        private void FilterComboBox_TextChanged(object sender, EventArgs e)
        {
            if (this.ForeColor == Color.Gray && this.Text != _placeholderText)
            {
                this.ForeColor = Color.Black;
            }

            // Filter items based on the text input
            FilterItems();
        }

        private void FilterComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text) || this.Text == _placeholderText)
            {
                UpdatePlaceholder();
            }
        }

        private void FilterComboBox_Enter(object sender, EventArgs e)
        {
            if (this.Text == _placeholderText && this.ForeColor == Color.Gray)
            {
                this.Text = string.Empty;
                this.ForeColor = Color.Black;
            }
        }

        private void FilterComboBox_DropDown(object sender, EventArgs e)
        {
            if (!_originalItems.Any())
            {
                _originalItems = this.Items.Cast<string>().ToList();
            }
        }

        private void FilterItems()
        {
            var filterText = this.Text;

            if (!string.IsNullOrEmpty(filterText) && filterText != _placeholderText)
            {
                var filteredItems = _originalItems.Where(item => item.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0).ToArray();
                this.Items.Clear();
                this.Items.AddRange(filteredItems);
            }
            else
            {
                // Restore original items if the filter text is empty
                this.Items.Clear();
                this.Items.AddRange(_originalItems.ToArray());
            }
        }

        public void SetItems(IEnumerable<string> items)
        {
            _originalItems = items.ToList();
            this.Items.Clear();
            this.Items.AddRange(_originalItems.ToArray());
        }
    }
}

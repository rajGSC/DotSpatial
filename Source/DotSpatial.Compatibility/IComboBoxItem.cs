// ********************************************************************************************************
// Product Name: DotSpatial.Compatibility.dll
// Description:  Supports DotSpatial interfaces organized for a MapWindow 4 plugin context.
// ********************************************************************************************************
//
// The Original Code is from MapWindow.dll version 6.0
//
// The Initial Developer of this Original Code is Ted Dunsford. Created 1/20/2009 3:51:03 PM
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
//
// ********************************************************************************************************

using System.Windows.Forms;

namespace DotSpatial.Compatibility
{
    /// <summary>
    /// Object given back when a ComboBox is added to the Toolbar.
    /// </summary>
    public interface IComboBoxItem
    {
        #region Properties

        /// <summary>
        /// Gets or sets the cursor
        /// </summary>
        Cursor Cursor { get; set; }

        /// <summary>
        /// Gets or sets the description for the control (used when the user customizes the Toolbar)
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the style of the combo box
        /// </summary>
        ComboBoxStyle DropDownStyle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the ComboBoxItem is enabled.
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// Gets the name of the ComboBoxItem object
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets or sets the zero based index of the selected item
        /// </summary>
        int SelectedIndex { get; set; }

        /// <summary>
        /// Gets or sets the selected object
        /// </summary>
        object SelectedItem { get; set; }

        /// <summary>
        /// Gets or sets the selected item text
        /// </summary>
        string SelectedText { get; set; }

        /// <summary>
        /// Gets or sets the length of the highlighted text
        /// </summary>
        int SelectionLength { get; set; }

        /// <summary>
        /// Gets or sets the start index of the highlighted text
        /// </summary>
        int SelectionStart { get; set; }

        /// <summary>
        /// Gets or sets the text for this object
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the tooltip text for the control
        /// </summary>
        string Tooltip { get; set; }

        /// <summary>
        /// Gets or sets the width of the control
        /// </summary>
        int Width { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a collection of items
        /// </summary>
        /// <returns>a collection of items</returns>
        ComboBox.ObjectCollection Items();

        #endregion
    }
}
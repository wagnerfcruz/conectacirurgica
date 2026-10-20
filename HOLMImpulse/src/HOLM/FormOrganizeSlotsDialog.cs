using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HOLM;

public class FormOrganizeSlotsDialog : Form
{
	public Button cancelButton;

	public Button okButton;

	public CheckedListBox listBox;

	public Button selectAllButton;

	private GroupBox groupBox1;

	public Button selectInvertButton;

	public Button selectNoneButton;

	public Button clearButton;

	private IContainer components;

	public bool[] clearList;

	public object[] orgList;

	private bool fIndexOnTheMove;

	private int indexOnTheMove;

	public FormOrganizeSlotsDialog()
	{
		try
		{
			InitializeComponent();
			fIndexOnTheMove = false;
			return;
		}
		catch
		{
			//try-fault
			((Form)this).Dispose(true);
			throw;
		}
	}

	private void _007EFormOrganizeSlotsDialog()
	{
		components?.Dispose();
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		listBox = new CheckedListBox();
		selectAllButton = new Button();
		groupBox1 = new GroupBox();
		selectInvertButton = new Button();
		selectNoneButton = new Button();
		clearButton = new Button();
		okButton = new Button();
		cancelButton = new Button();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)listBox).Anchor = (AnchorStyles)15;
		object[] array = new object[15]
		{
			"test text1", "test text2", "test text3", "test text4", "test text5", "test text6", "test text7", "test text8", "test text9", "test text10",
			"test text11", "test text12", "test text13", "test text14", "test text15"
		};
		((ObjectCollection)listBox.Items).AddRange(array);
		Point location = new Point(3, 6);
		((Control)listBox).Location = location;
		((Control)listBox).Name = "listBox";
		Size size = new Size(188, 229);
		((Control)listBox).Size = size;
		((Control)listBox).TabIndex = 1;
		listBox.ThreeDCheckBoxes = true;
		((Control)listBox).MouseUp += new MouseEventHandler(listBox_MouseUp);
		((Control)listBox).MouseMove += new MouseEventHandler(listBox_MouseMove);
		((Control)listBox).MouseDown += new MouseEventHandler(listBox_MouseDown);
		Point location2 = new Point(12, 17);
		((Control)selectAllButton).Location = location2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin);
		((Padding)(ref margin))._002Ector(1);
		((Control)selectAllButton).Margin = margin;
		((Control)selectAllButton).Name = "selectAllButton";
		Size size2 = new Size(46, 21);
		((Control)selectAllButton).Size = size2;
		((Control)selectAllButton).TabIndex = 2;
		((ButtonBase)selectAllButton).Text = "All";
		((ButtonBase)selectAllButton).UseVisualStyleBackColor = true;
		((Control)selectAllButton).Click += selectAllButton_Click;
		((Control)groupBox1).Anchor = (AnchorStyles)9;
		((Control)groupBox1).Controls.Add((Control)(object)selectInvertButton);
		((Control)groupBox1).Controls.Add((Control)(object)selectNoneButton);
		((Control)groupBox1).Controls.Add((Control)(object)clearButton);
		((Control)groupBox1).Controls.Add((Control)(object)selectAllButton);
		Point location3 = new Point(194, 0);
		((Control)groupBox1).Location = location3;
		((Control)groupBox1).Name = "groupBox1";
		Size size3 = new Size(72, 120);
		((Control)groupBox1).Size = size3;
		((Control)groupBox1).TabIndex = 3;
		groupBox1.TabStop = false;
		groupBox1.Text = "Selection";
		Point location4 = new Point(12, 63);
		((Control)selectInvertButton).Location = location4;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin2);
		((Padding)(ref margin2))._002Ector(1);
		((Control)selectInvertButton).Margin = margin2;
		((Control)selectInvertButton).Name = "selectInvertButton";
		Size size4 = new Size(46, 21);
		((Control)selectInvertButton).Size = size4;
		((Control)selectInvertButton).TabIndex = 4;
		((ButtonBase)selectInvertButton).Text = "Invert";
		((ButtonBase)selectInvertButton).UseVisualStyleBackColor = true;
		((Control)selectInvertButton).Click += selectInvertButton_Click;
		Point location5 = new Point(12, 40);
		((Control)selectNoneButton).Location = location5;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin3);
		((Padding)(ref margin3))._002Ector(1);
		((Control)selectNoneButton).Margin = margin3;
		((Control)selectNoneButton).Name = "selectNoneButton";
		Size size5 = new Size(46, 21);
		((Control)selectNoneButton).Size = size5;
		((Control)selectNoneButton).TabIndex = 3;
		((ButtonBase)selectNoneButton).Text = "None";
		((ButtonBase)selectNoneButton).UseVisualStyleBackColor = true;
		((Control)selectNoneButton).Click += selectNoneButton_Click;
		((Control)clearButton).Anchor = (AnchorStyles)9;
		Point location6 = new Point(12, 92);
		((Control)clearButton).Location = location6;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Padding margin4);
		((Padding)(ref margin4))._002Ector(1);
		((Control)clearButton).Margin = margin4;
		((Control)clearButton).Name = "clearButton";
		Size size6 = new Size(46, 21);
		((Control)clearButton).Size = size6;
		((Control)clearButton).TabIndex = 3;
		((ButtonBase)clearButton).Text = "Clear";
		((ButtonBase)clearButton).UseVisualStyleBackColor = true;
		((Control)clearButton).Click += clearButton_Click;
		((Control)okButton).Anchor = (AnchorStyles)9;
		okButton.DialogResult = (DialogResult)1;
		Point location7 = new Point(194, 152);
		((Control)okButton).Location = location7;
		((Control)okButton).Name = "okButton";
		Size size7 = new Size(69, 23);
		((Control)okButton).Size = size7;
		((Control)okButton).TabIndex = 0;
		((ButtonBase)okButton).Text = "&Ok";
		((ButtonBase)okButton).UseVisualStyleBackColor = true;
		((Control)cancelButton).Anchor = (AnchorStyles)9;
		cancelButton.DialogResult = (DialogResult)2;
		Point location8 = new Point(194, 125);
		((Control)cancelButton).Location = location8;
		((Control)cancelButton).Name = "cancelButton";
		Size size8 = new Size(69, 23);
		((Control)cancelButton).Size = size8;
		((Control)cancelButton).TabIndex = 5;
		((ButtonBase)cancelButton).Text = "Cancel";
		((ButtonBase)cancelButton).UseVisualStyleBackColor = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		Size clientSize = new Size(268, 240);
		((Form)this).ClientSize = clientSize;
		((Control)this).Controls.Add((Control)(object)cancelButton);
		((Control)this).Controls.Add((Control)(object)okButton);
		((Control)this).Controls.Add((Control)(object)groupBox1);
		((Control)this).Controls.Add((Control)(object)listBox);
		((Form)this).FormBorderStyle = (FormBorderStyle)6;
		((Form)this).MaximizeBox = false;
		((Form)this).MinimizeBox = false;
		Size minimumSize = new Size(260, 200);
		((Form)this).MinimumSize = minimumSize;
		((Control)this).Name = "FormOrganizeSlotsDialog";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).Text = "Organize Measurements";
		((Form)this).TopMost = true;
		((Control)groupBox1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void InitializeLists()
	{
		clearList = new bool[((ObjectCollection)listBox.Items).Count];
		orgList = new object[((ObjectCollection)listBox.Items).Count];
		int num = 0;
		if (0 < ((ObjectCollection)listBox.Items).Count)
		{
			do
			{
				clearList[num] = false;
				orgList[num] = ((ObjectCollection)listBox.Items)[num];
				num++;
			}
			while (num < ((ObjectCollection)listBox.Items).Count);
		}
		int num2 = ((ObjectCollection)listBox.Items).Count * 15 + 40;
		if (num2 < 200)
		{
			num2 = 200;
		}
		else if (num2 >= 400)
		{
			goto IL_00ba;
		}
		((Form)this).FormBorderStyle = (FormBorderStyle)3;
		goto IL_00ba;
		IL_00ba:
		if (num2 > 600)
		{
			num2 = 600;
		}
		((Control)this).Height = num2;
	}

	private void listBox_MouseMove(object sender, MouseEventArgs e)
	{
		if (global::_003CModule_003E._003Flastindex_0040_003F1_003F_003FlistBox_MouseMove_0040FormOrganizeSlotsDialog_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVMouseEventArgs_0040Forms_0040Windows_00405_0040_0040Z_00404HA != ((ListBox)listBox).SelectedIndex)
		{
			if (fIndexOnTheMove && ((ListBox)listBox).SelectedIndex != indexOnTheMove && ((ListBox)listBox).SelectedIndex != -1)
			{
				int selectedIndex = ((ListBox)listBox).SelectedIndex;
				object obj = ((ObjectCollection)listBox.Items)[indexOnTheMove];
				((ObjectCollection)listBox.Items).Remove(obj);
				((ObjectCollection)listBox.Items).Insert(selectedIndex, obj);
				indexOnTheMove = selectedIndex;
			}
			global::_003CModule_003E._003Flastindex_0040_003F1_003F_003FlistBox_MouseMove_0040FormOrganizeSlotsDialog_0040HOLM_0040_0040A_0024AAMXP_0024AAVObject_0040System_0040_0040P_0024AAVMouseEventArgs_0040Forms_0040Windows_00405_0040_0040Z_00404HA = ((ListBox)listBox).SelectedIndex;
		}
	}

	private void listBox_MouseDown(object sender, MouseEventArgs e)
	{
		fIndexOnTheMove = true;
		indexOnTheMove = ((ListBox)listBox).SelectedIndex;
	}

	private void listBox_MouseUp(object sender, MouseEventArgs e)
	{
		fIndexOnTheMove = false;
	}

	private void selectAllButton_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (0 < ((ObjectCollection)listBox.Items).Count)
		{
			do
			{
				listBox.SetItemChecked(num, true);
				num++;
			}
			while (num < ((ObjectCollection)listBox.Items).Count);
		}
	}

	private void selectNoneButton_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (0 < ((ObjectCollection)listBox.Items).Count)
		{
			do
			{
				listBox.SetItemChecked(num, false);
				num++;
			}
			while (num < ((ObjectCollection)listBox.Items).Count);
		}
	}

	private void selectInvertButton_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (0 < ((ObjectCollection)listBox.Items).Count)
		{
			do
			{
				byte b = ((!listBox.GetItemChecked(num)) ? ((byte)1) : ((byte)0));
				listBox.SetItemChecked(num, b != 0);
				num++;
			}
			while (num < ((ObjectCollection)listBox.Items).Count);
		}
	}

	private void clearButton_Click(object sender, EventArgs e)
	{
		int num = 0;
		if (0 >= ((ObjectCollection)listBox.Items).Count)
		{
			return;
		}
		do
		{
			if (listBox.GetItemChecked(num))
			{
				int num2 = 0;
				if (0 < ((ObjectCollection)listBox.Items).Count)
				{
					while (orgList[num2] != ((ObjectCollection)listBox.Items)[num])
					{
						num2++;
						if (num2 >= ((ObjectCollection)listBox.Items).Count)
						{
							break;
						}
					}
				}
				clearList[num2] = true;
				int num3 = num;
				((ObjectCollection)listBox.Items)[num] = "Empty " + num3;
				orgList[num2] = ((ObjectCollection)listBox.Items)[num];
				listBox.SetItemChecked(num, false);
			}
			num++;
		}
		while (num < ((ObjectCollection)listBox.Items).Count);
	}

	protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (P_0)
		{
			try
			{
				_007EFormOrganizeSlotsDialog();
				return;
			}
			finally
			{
				((Form)this).Dispose(true);
			}
		}
		((Form)this).Dispose(false);
	}
}

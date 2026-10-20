using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace HOLM.GuiHelper;

internal class NumericTextBox
{
	private EventHandler _003Cbacking_store_003ENewValue;

	public double min;

	public double max;

	public int NofDigits;

	private ToolStripTextBox textBox;

	private TextBox textBoxN;

	private double currentValue;

	[SpecialName]
	public event EventHandler NewValue
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			_003Cbacking_store_003ENewValue = (EventHandler)Delegate.Combine(_003Cbacking_store_003ENewValue, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			_003Cbacking_store_003ENewValue = (EventHandler)Delegate.Remove(_003Cbacking_store_003ENewValue, value);
		}
	}

	public NumericTextBox(TextBox inTextBox, double minIn, double maxIn, int NofDigitsIn)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		textBoxN = inTextBox;
		((Control)textBoxN).KeyDown += new KeyEventHandler(Action_Key);
		((Control)textBoxN).LostFocus += Action_Update;
		min = minIn;
		max = maxIn;
		NofDigits = NofDigitsIn;
		textBox = null;
	}

	public NumericTextBox(ToolStripTextBox inTextBox, double minIn, double maxIn, int NofDigitsIn)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		textBox = inTextBox;
		((ToolStripControlHost)textBox).KeyDown += new KeyEventHandler(Action_Key);
		((ToolStripControlHost)textBox).LostFocus += Action_Update;
		min = minIn;
		max = maxIn;
		NofDigits = NofDigitsIn;
		textBoxN = null;
	}

	public double GetValue()
	{
		return currentValue;
	}

	public int GetValueInt()
	{
		return (int)currentValue;
	}

	public void SetValue(decimal newValueD)
	{
		double num = decimal.ToDouble(newValueD);
		if (num >= min && num <= max)
		{
			currentValue = num;
			UpdateText();
		}
	}

	public void SetValue(double newValue)
	{
		if (newValue >= min && newValue <= max)
		{
			currentValue = newValue;
			UpdateText();
		}
	}

	[SpecialName]
	protected void raise_NewValue(object value0, EventArgs value1)
	{
		_003Cbacking_store_003ENewValue?.Invoke(value0, value1);
	}

	public void UpdateText()
	{
		int nofDigits = NofDigits;
		string text;
		if (nofDigits > 0)
		{
			text = global::_003CModule_003E.HOLM_002EGuiHelper_002EDigitsString(currentValue, nofDigits);
		}
		else
		{
			double num = currentValue;
			text = num.ToString("F0");
		}
		ToolStripTextBox val = textBox;
		if (val != null)
		{
			((ToolStripControlHost)val).Text = text;
		}
		TextBox val2 = textBoxN;
		if (val2 != null)
		{
			val2.Text = text;
		}
	}

	private void Action_Key(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		if ((int)e.KeyCode == 13)
		{
			Action_Update(sender, (EventArgs)(object)e);
		}
		else if ((int)e.KeyCode == 27)
		{
			UpdateText();
		}
	}

	private void Action_Update(object sender, EventArgs e)
	{
		ToolStripTextBox val = textBox;
		bool flag;
		double result;
		if (sender == val)
		{
			flag = double.TryParse(((ToolStripControlHost)val).Text, out result);
		}
		else
		{
			TextBox val2 = textBoxN;
			if (sender != val2)
			{
				goto IL_0095;
			}
			flag = double.TryParse(val2.Text, out result);
		}
		if (flag)
		{
			if (result >= min && result <= max)
			{
				SetValue(result);
			}
			else if (result < min)
			{
				SetValue(min);
			}
			else if (result > max)
			{
				SetValue(max);
			}
			_003Cbacking_store_003ENewValue?.Invoke(this, null);
			return;
		}
		goto IL_0095;
		IL_0095:
		UpdateText();
	}
}

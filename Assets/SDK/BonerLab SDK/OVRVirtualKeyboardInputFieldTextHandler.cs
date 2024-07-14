using System;
using UnityEngine;
using UnityEngine.UI;

public class OVRVirtualKeyboardInputFieldTextHandler : OVRVirtualKeyboard.AbstractTextHandler
{
	[SerializeField]
	private InputField inputField;

	private bool _isSelected;

	public InputField InputField
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override Action<string> OnTextChanged { get; set; }

	public override string Text => null;

	public override bool SubmitOnEnter => false;

	public override bool IsFocused => false;

	public override void Submit()
	{
	}

	public override void AppendText(string s)
	{
	}

	public override void ApplyBackspace()
	{
	}

	public override void MoveTextEnd()
	{
	}

	protected void Start()
	{
	}

	protected void ProxyOnValueChanged(string arg0)
	{
	}
}

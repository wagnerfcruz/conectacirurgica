using System.Xml.Serialization;

namespace HOLM.HOLMImpulse.Conf;

[XmlRoot("HOLMImpulseOptions", IsNullable = false)]
public class OptionsTestField
{
	[XmlElement(IsNullable = false)]
	public string WriterProductVersion;
}

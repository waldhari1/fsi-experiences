//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.CloudForFSI.Tables
{
	
	/// <summary>
	/// Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("organization")]
	public partial class Organization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Organization() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "organization";
		
		public const string EntitySchemaName = "Organization";
		
		public const string PrimaryIdAttribute = "organizationid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "organizations";
		
		public const string EntitySetName = "organizations";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// ACI Web Endpoint URL.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aciwebendpointurl")]
		public string ACIWebEndpointUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("aciwebendpointurl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ACIWebEndpointUrl");
				this.SetAttributeValue("aciwebendpointurl", value);
				this.OnPropertyChanged("ACIWebEndpointUrl");
			}
		}
		
		/// <summary>
		/// Unique identifier of the template to be used for acknowledgement when a user unsubscribes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("acknowledgementtemplateid")]
		public Microsoft.Xrm.Sdk.EntityReference AcknowledgementTemplateId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("acknowledgementtemplateid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AcknowledgementTemplateId");
				this.SetAttributeValue("acknowledgementtemplateid", value);
				this.OnPropertyChanged("AcknowledgementTemplateId");
			}
		}
		
		/// <summary>
		/// Information on whether filtering activity based on entity in app.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypefilter")]
		public System.Nullable<bool> ActivityTypeFilter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("activitytypefilter");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivityTypeFilter");
				this.SetAttributeValue("activitytypefilter", value);
				this.OnPropertyChanged("ActivityTypeFilter");
			}
		}

		/// <summary>
		/// Maximum allowed size of an attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxuploadfilesize")]
		public System.Nullable<int> MaxUploadFileSize
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("maxuploadfilesize");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MaxUploadFileSize");
				this.SetAttributeValue("maxuploadfilesize", value);
				this.OnPropertyChanged("MaxUploadFileSize");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Organization(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["organizationid"] = base.Id;
                        break;
                    case "organizationid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}
// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.32989
//    <NameSpace>WSOL.EktronCms.ContentMaker.Samples</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace WSOL.Custom.ContentMaker.Samples.ContentTypes.FolderSettings
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    public partial class root
    {

        private List<FolderIdRefType> folderIDField;

        private string sectionTitleField;

        public root()
        {
            this.folderIDField = new List<FolderIdRefType>();
        }

        public List<FolderIdRefType> FolderID
        {
            get
            {
                return this.folderIDField;
            }
            set
            {
                this.folderIDField = value;
            }
        }

        public string SectionTitle
        {
            get
            {
                return this.sectionTitleField;
            }
            set
            {
                this.sectionTitleField = value;
            }
        }
    }

    public partial class FolderIdRefType : IdRefType
    {
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FolderIdRefType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContentIdRefType))]
    public partial class IdRefType
    {

        private string datavalue_idtypeField;

        private string datavalue_displayvalueField;

        private long valueField;

        public string datavalue_idtype
        {
            get
            {
                return this.datavalue_idtypeField;
            }
            set
            {
                this.datavalue_idtypeField = value;
            }
        }

        public string datavalue_displayvalue
        {
            get
            {
                return this.datavalue_displayvalueField;
            }
            set
            {
                this.datavalue_displayvalueField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    public partial class ContentIdRefType : IdRefType
    {
    }
}

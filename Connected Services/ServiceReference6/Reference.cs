﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference6
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", ConfigurationName="ServiceReference6.Users_Port")]
    public interface Users_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.Read_Result Read(ServiceReference6.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Read", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.Read_Result> ReadAsync(ServiceReference6.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.ReadByRecId_Result ReadByRecId(ServiceReference6.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:ReadByRecId", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.ReadByRecId_Result> ReadByRecIdAsync(ServiceReference6.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.ReadMultiple_Result ReadMultiple(ServiceReference6.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:ReadMultiple", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.ReadMultiple_Result> ReadMultipleAsync(ServiceReference6.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.IsUpdated_Result IsUpdated(ServiceReference6.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:IsUpdated", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.IsUpdated_Result> IsUpdatedAsync(ServiceReference6.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.GetRecIdFromKey_Result GetRecIdFromKey(ServiceReference6.GetRecIdFromKey request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:GetRecIdFromKey", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(ServiceReference6.GetRecIdFromKey request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Create", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.Create_Result Create(ServiceReference6.Create request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Create", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.Create_Result> CreateAsync(ServiceReference6.Create request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:CreateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.CreateMultiple_Result CreateMultiple(ServiceReference6.CreateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:CreateMultiple", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.CreateMultiple_Result> CreateMultipleAsync(ServiceReference6.CreateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.Update_Result Update(ServiceReference6.Update request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Update", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.Update_Result> UpdateAsync(ServiceReference6.Update request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:UpdateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.UpdateMultiple_Result UpdateMultiple(ServiceReference6.UpdateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:UpdateMultiple", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.UpdateMultiple_Result> UpdateMultipleAsync(ServiceReference6.UpdateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ServiceReference6.Delete_Result Delete(ServiceReference6.Delete request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/users:Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference6.Delete_Result> DeleteAsync(ServiceReference6.Delete request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users")]
    public partial class Users
    {
        
        private string keyField;
        
        private string user_Security_IDField;
        
        private string user_NameField;
        
        private string full_NameField;
        
        private string windows_Security_IDField;
        
        private string windows_User_NameField;
        
        private License_Type license_TypeField;
        
        private bool license_TypeFieldSpecified;
        
        private string authentication_EmailField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string User_Security_ID
        {
            get
            {
                return this.user_Security_IDField;
            }
            set
            {
                this.user_Security_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string User_Name
        {
            get
            {
                return this.user_NameField;
            }
            set
            {
                this.user_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Full_Name
        {
            get
            {
                return this.full_NameField;
            }
            set
            {
                this.full_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Windows_Security_ID
        {
            get
            {
                return this.windows_Security_IDField;
            }
            set
            {
                this.windows_Security_IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Windows_User_Name
        {
            get
            {
                return this.windows_User_NameField;
            }
            set
            {
                this.windows_User_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public License_Type License_Type
        {
            get
            {
                return this.license_TypeField;
            }
            set
            {
                this.license_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool License_TypeSpecified
        {
            get
            {
                return this.license_TypeFieldSpecified;
            }
            set
            {
                this.license_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Authentication_Email
        {
            get
            {
                return this.authentication_EmailField;
            }
            set
            {
                this.authentication_EmailField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users")]
    public enum License_Type
    {
        
        /// <remarks/>
        Full_User,
        
        /// <remarks/>
        Limited_User,
        
        /// <remarks/>
        Device_Only_User,
        
        /// <remarks/>
        Windows_Group,
        
        /// <remarks/>
        External_User,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users")]
    public partial class Users_Filter
    {
        
        private Users_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Users_Fields Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users")]
    public enum Users_Fields
    {
        
        /// <remarks/>
        User_Security_ID,
        
        /// <remarks/>
        User_Name,
        
        /// <remarks/>
        Full_Name,
        
        /// <remarks/>
        Windows_Security_ID,
        
        /// <remarks/>
        Windows_User_Name,
        
        /// <remarks/>
        License_Type,
        
        /// <remarks/>
        Authentication_Email,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Read
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public string User_Security_ID;
        
        public Read()
        {
        }
        
        public Read(string User_Security_ID)
        {
            this.User_Security_ID = User_Security_ID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Read_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public ServiceReference6.Users Users;
        
        public Read_Result()
        {
        }
        
        public Read_Result(ServiceReference6.Users Users)
        {
            this.Users = Users;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class ReadByRecId
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public string recId;
        
        public ReadByRecId()
        {
        }
        
        public ReadByRecId(string recId)
        {
            this.recId = recId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class ReadByRecId_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public ServiceReference6.Users Users;
        
        public ReadByRecId_Result()
        {
        }
        
        public ReadByRecId_Result(ServiceReference6.Users Users)
        {
            this.Users = Users;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class ReadMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public ServiceReference6.Users_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=2)]
        public int setSize;
        
        public ReadMultiple()
        {
        }
        
        public ReadMultiple(ServiceReference6.Users_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class ReadMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadMultiple_Result", Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ServiceReference6.Users[] ReadMultiple_Result1;
        
        public ReadMultiple_Result()
        {
        }
        
        public ReadMultiple_Result(ServiceReference6.Users[] ReadMultiple_Result1)
        {
            this.ReadMultiple_Result1 = ReadMultiple_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class IsUpdated
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public string Key;
        
        public IsUpdated()
        {
        }
        
        public IsUpdated(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class IsUpdated_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUpdated_Result", Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public bool IsUpdated_Result1;
        
        public IsUpdated_Result()
        {
        }
        
        public IsUpdated_Result(bool IsUpdated_Result1)
        {
            this.IsUpdated_Result1 = IsUpdated_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class GetRecIdFromKey
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public string Key;
        
        public GetRecIdFromKey()
        {
        }
        
        public GetRecIdFromKey(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class GetRecIdFromKey_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecIdFromKey_Result", Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public string GetRecIdFromKey_Result1;
        
        public GetRecIdFromKey_Result()
        {
        }
        
        public GetRecIdFromKey_Result(string GetRecIdFromKey_Result1)
        {
            this.GetRecIdFromKey_Result1 = GetRecIdFromKey_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Create
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public ServiceReference6.Users Users;
        
        public Create()
        {
        }
        
        public Create(ServiceReference6.Users Users)
        {
            this.Users = Users;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Create_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public ServiceReference6.Users Users;
        
        public Create_Result()
        {
        }
        
        public Create_Result(ServiceReference6.Users Users)
        {
            this.Users = Users;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class CreateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ServiceReference6.Users[] Users_List;
        
        public CreateMultiple()
        {
        }
        
        public CreateMultiple(ServiceReference6.Users[] Users_List)
        {
            this.Users_List = Users_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class CreateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ServiceReference6.Users[] Users_List;
        
        public CreateMultiple_Result()
        {
        }
        
        public CreateMultiple_Result(ServiceReference6.Users[] Users_List)
        {
            this.Users_List = Users_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Update
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public ServiceReference6.Users Users;
        
        public Update()
        {
        }
        
        public Update(ServiceReference6.Users Users)
        {
            this.Users = Users;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Update_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public ServiceReference6.Users Users;
        
        public Update_Result()
        {
        }
        
        public Update_Result(ServiceReference6.Users Users)
        {
            this.Users = Users;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class UpdateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ServiceReference6.Users[] Users_List;
        
        public UpdateMultiple()
        {
        }
        
        public UpdateMultiple(ServiceReference6.Users[] Users_List)
        {
            this.Users_List = Users_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class UpdateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public ServiceReference6.Users[] Users_List;
        
        public UpdateMultiple_Result()
        {
        }
        
        public UpdateMultiple_Result(ServiceReference6.Users[] Users_List)
        {
            this.Users_List = Users_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Delete
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public string Key;
        
        public Delete()
        {
        }
        
        public Delete(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/users", IsWrapped=true)]
    public partial class Delete_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete_Result", Namespace="urn:microsoft-dynamics-schemas/page/users", Order=0)]
        public bool Delete_Result1;
        
        public Delete_Result()
        {
        }
        
        public Delete_Result(bool Delete_Result1)
        {
            this.Delete_Result1 = Delete_Result1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface Users_PortChannel : ServiceReference6.Users_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Users_PortClient : System.ServiceModel.ClientBase<ServiceReference6.Users_Port>, ServiceReference6.Users_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Users_PortClient() : 
                base(Users_PortClient.GetDefaultBinding(), Users_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.Users_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Users_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(Users_PortClient.GetBindingForEndpoint(endpointConfiguration), Users_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Users_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Users_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Users_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Users_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Users_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ServiceReference6.Read_Result Read(ServiceReference6.Read request)
        {
            return base.Channel.Read(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.Read_Result> ReadAsync(ServiceReference6.Read request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public ServiceReference6.ReadByRecId_Result ReadByRecId(ServiceReference6.ReadByRecId request)
        {
            return base.Channel.ReadByRecId(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.ReadByRecId_Result> ReadByRecIdAsync(ServiceReference6.ReadByRecId request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public ServiceReference6.ReadMultiple_Result ReadMultiple(ServiceReference6.ReadMultiple request)
        {
            return base.Channel.ReadMultiple(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.ReadMultiple_Result> ReadMultipleAsync(ServiceReference6.ReadMultiple request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public ServiceReference6.IsUpdated_Result IsUpdated(ServiceReference6.IsUpdated request)
        {
            return base.Channel.IsUpdated(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.IsUpdated_Result> IsUpdatedAsync(ServiceReference6.IsUpdated request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public ServiceReference6.GetRecIdFromKey_Result GetRecIdFromKey(ServiceReference6.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKey(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(ServiceReference6.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public ServiceReference6.Create_Result Create(ServiceReference6.Create request)
        {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.Create_Result> CreateAsync(ServiceReference6.Create request)
        {
            return base.Channel.CreateAsync(request);
        }
        
        public ServiceReference6.CreateMultiple_Result CreateMultiple(ServiceReference6.CreateMultiple request)
        {
            return base.Channel.CreateMultiple(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.CreateMultiple_Result> CreateMultipleAsync(ServiceReference6.CreateMultiple request)
        {
            return base.Channel.CreateMultipleAsync(request);
        }
        
        public ServiceReference6.Update_Result Update(ServiceReference6.Update request)
        {
            return base.Channel.Update(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.Update_Result> UpdateAsync(ServiceReference6.Update request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        public ServiceReference6.UpdateMultiple_Result UpdateMultiple(ServiceReference6.UpdateMultiple request)
        {
            return base.Channel.UpdateMultiple(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.UpdateMultiple_Result> UpdateMultipleAsync(ServiceReference6.UpdateMultiple request)
        {
            return base.Channel.UpdateMultipleAsync(request);
        }
        
        public ServiceReference6.Delete_Result Delete(ServiceReference6.Delete request)
        {
            return base.Channel.Delete(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference6.Delete_Result> DeleteAsync(ServiceReference6.Delete request)
        {
            return base.Channel.DeleteAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Users_Port))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Users_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://ochiengowino:3332/CapitalSaccoInstance/WS/CAPITAL SACCO/Page/Users");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Users_PortClient.GetBindingForEndpoint(EndpointConfiguration.Users_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Users_PortClient.GetEndpointAddress(EndpointConfiguration.Users_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            Users_Port,
        }
    }
}
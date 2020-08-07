using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace Zero.Data.Projects
{
    /// <summary>产品</summary>
    [Serializable]
    [DataObject]
    [Description("产品")]
    [BindIndex("IU_Product_Name", true, "Name")]
    [BindTable("Product", Description = "产品", ConnName = "OA", DbType = DatabaseType.None)]
    public partial class Product : IProduct
    {
        #region 属性
        private Int32 _ID;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("ID", "编号", "")]
        public Int32 ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

        private Int32 _TeamId;
        /// <summary>团队</summary>
        [DisplayName("团队")]
        [Description("团队")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("TeamId", "团队", "")]
        public Int32 TeamId { get => _TeamId; set { if (OnPropertyChanging("TeamId", value)) { _TeamId = value; OnPropertyChanged("TeamId"); } } }

        private String _Name;
        /// <summary>名称</summary>
        [DisplayName("名称")]
        [Description("名称")]
        [DataObjectField(false, false, false, 50)]
        [BindColumn("Name", "名称", "", Master = true)]
        public String Name { get => _Name; set { if (OnPropertyChanging("Name", value)) { _Name = value; OnPropertyChanged("Name"); } } }

        private String _Kind;
        /// <summary>类型</summary>
        [DisplayName("类型")]
        [Description("类型")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("Kind", "类型", "")]
        public String Kind { get => _Kind; set { if (OnPropertyChanging("Kind", value)) { _Kind = value; OnPropertyChanged("Kind"); } } }

        private Int32 _LeaderId;
        /// <summary>负责人</summary>
        [DisplayName("负责人")]
        [Description("负责人")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("LeaderId", "负责人", "")]
        public Int32 LeaderId { get => _LeaderId; set { if (OnPropertyChanging("LeaderId", value)) { _LeaderId = value; OnPropertyChanged("LeaderId"); } } }

        private Boolean _Enable;
        /// <summary>启用</summary>
        [DisplayName("启用")]
        [Description("启用")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Enable", "启用", "")]
        public Boolean Enable { get => _Enable; set { if (OnPropertyChanging("Enable", value)) { _Enable = value; OnPropertyChanged("Enable"); } } }

        private Int32 _Versions;
        /// <summary>版本数</summary>
        [DisplayName("版本数")]
        [Description("版本数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Versions", "版本数", "")]
        public Int32 Versions { get => _Versions; set { if (OnPropertyChanging("Versions", value)) { _Versions = value; OnPropertyChanged("Versions"); } } }

        private Int32 _Stories;
        /// <summary>故事数</summary>
        [DisplayName("故事数")]
        [Description("故事数")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Stories", "故事数", "")]
        public Int32 Stories { get => _Stories; set { if (OnPropertyChanging("Stories", value)) { _Stories = value; OnPropertyChanged("Stories"); } } }

        private Boolean _Completed;
        /// <summary>完成</summary>
        [DisplayName("完成")]
        [Description("完成")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Completed", "完成", "")]
        public Boolean Completed { get => _Completed; set { if (OnPropertyChanging("Completed", value)) { _Completed = value; OnPropertyChanged("Completed"); } } }

        private String _CreateUser;
        /// <summary>创建者</summary>
        [DisplayName("创建者")]
        [Description("创建者")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateUser", "创建者", "")]
        public String CreateUser { get => _CreateUser; set { if (OnPropertyChanging("CreateUser", value)) { _CreateUser = value; OnPropertyChanged("CreateUser"); } } }

        private Int32 _CreateUserID;
        /// <summary>创建人</summary>
        [DisplayName("创建人")]
        [Description("创建人")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("CreateUserID", "创建人", "")]
        public Int32 CreateUserID { get => _CreateUserID; set { if (OnPropertyChanging("CreateUserID", value)) { _CreateUserID = value; OnPropertyChanged("CreateUserID"); } } }

        private String _CreateIP;
        /// <summary>创建地址</summary>
        [DisplayName("创建地址")]
        [Description("创建地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("CreateIP", "创建地址", "")]
        public String CreateIP { get => _CreateIP; set { if (OnPropertyChanging("CreateIP", value)) { _CreateIP = value; OnPropertyChanged("CreateIP"); } } }

        private DateTime _CreateTime;
        /// <summary>创建时间</summary>
        [DisplayName("创建时间")]
        [Description("创建时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("CreateTime", "创建时间", "")]
        public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

        private String _UpdateUser;
        /// <summary>更新者</summary>
        [DisplayName("更新者")]
        [Description("更新者")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateUser", "更新者", "")]
        public String UpdateUser { get => _UpdateUser; set { if (OnPropertyChanging("UpdateUser", value)) { _UpdateUser = value; OnPropertyChanged("UpdateUser"); } } }

        private Int32 _UpdateUserID;
        /// <summary>更新人</summary>
        [DisplayName("更新人")]
        [Description("更新人")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UpdateUserID", "更新人", "")]
        public Int32 UpdateUserID { get => _UpdateUserID; set { if (OnPropertyChanging("UpdateUserID", value)) { _UpdateUserID = value; OnPropertyChanged("UpdateUserID"); } } }

        private String _UpdateIP;
        /// <summary>更新地址</summary>
        [DisplayName("更新地址")]
        [Description("更新地址")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("UpdateIP", "更新地址", "")]
        public String UpdateIP { get => _UpdateIP; set { if (OnPropertyChanging("UpdateIP", value)) { _UpdateIP = value; OnPropertyChanged("UpdateIP"); } } }

        private DateTime _UpdateTime;
        /// <summary>更新时间</summary>
        [DisplayName("更新时间")]
        [Description("更新时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("UpdateTime", "更新时间", "")]
        public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }

        private String _Remark;
        /// <summary>备注</summary>
        [DisplayName("备注")]
        [Description("备注")]
        [DataObjectField(false, false, true, 500)]
        [BindColumn("Remark", "备注", "")]
        public String Remark { get => _Remark; set { if (OnPropertyChanging("Remark", value)) { _Remark = value; OnPropertyChanged("Remark"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "ID": return _ID;
                    case "TeamId": return _TeamId;
                    case "Name": return _Name;
                    case "Kind": return _Kind;
                    case "LeaderId": return _LeaderId;
                    case "Enable": return _Enable;
                    case "Versions": return _Versions;
                    case "Stories": return _Stories;
                    case "Completed": return _Completed;
                    case "CreateUser": return _CreateUser;
                    case "CreateUserID": return _CreateUserID;
                    case "CreateIP": return _CreateIP;
                    case "CreateTime": return _CreateTime;
                    case "UpdateUser": return _UpdateUser;
                    case "UpdateUserID": return _UpdateUserID;
                    case "UpdateIP": return _UpdateIP;
                    case "UpdateTime": return _UpdateTime;
                    case "Remark": return _Remark;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "ID": _ID = value.ToInt(); break;
                    case "TeamId": _TeamId = value.ToInt(); break;
                    case "Name": _Name = Convert.ToString(value); break;
                    case "Kind": _Kind = Convert.ToString(value); break;
                    case "LeaderId": _LeaderId = value.ToInt(); break;
                    case "Enable": _Enable = value.ToBoolean(); break;
                    case "Versions": _Versions = value.ToInt(); break;
                    case "Stories": _Stories = value.ToInt(); break;
                    case "Completed": _Completed = value.ToBoolean(); break;
                    case "CreateUser": _CreateUser = Convert.ToString(value); break;
                    case "CreateUserID": _CreateUserID = value.ToInt(); break;
                    case "CreateIP": _CreateIP = Convert.ToString(value); break;
                    case "CreateTime": _CreateTime = value.ToDateTime(); break;
                    case "UpdateUser": _UpdateUser = Convert.ToString(value); break;
                    case "UpdateUserID": _UpdateUserID = value.ToInt(); break;
                    case "UpdateIP": _UpdateIP = Convert.ToString(value); break;
                    case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                    case "Remark": _Remark = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得产品字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field ID = FindByName("ID");

            /// <summary>团队</summary>
            public static readonly Field TeamId = FindByName("TeamId");

            /// <summary>名称</summary>
            public static readonly Field Name = FindByName("Name");

            /// <summary>类型</summary>
            public static readonly Field Kind = FindByName("Kind");

            /// <summary>负责人</summary>
            public static readonly Field LeaderId = FindByName("LeaderId");

            /// <summary>启用</summary>
            public static readonly Field Enable = FindByName("Enable");

            /// <summary>版本数</summary>
            public static readonly Field Versions = FindByName("Versions");

            /// <summary>故事数</summary>
            public static readonly Field Stories = FindByName("Stories");

            /// <summary>完成</summary>
            public static readonly Field Completed = FindByName("Completed");

            /// <summary>创建者</summary>
            public static readonly Field CreateUser = FindByName("CreateUser");

            /// <summary>创建人</summary>
            public static readonly Field CreateUserID = FindByName("CreateUserID");

            /// <summary>创建地址</summary>
            public static readonly Field CreateIP = FindByName("CreateIP");

            /// <summary>创建时间</summary>
            public static readonly Field CreateTime = FindByName("CreateTime");

            /// <summary>更新者</summary>
            public static readonly Field UpdateUser = FindByName("UpdateUser");

            /// <summary>更新人</summary>
            public static readonly Field UpdateUserID = FindByName("UpdateUserID");

            /// <summary>更新地址</summary>
            public static readonly Field UpdateIP = FindByName("UpdateIP");

            /// <summary>更新时间</summary>
            public static readonly Field UpdateTime = FindByName("UpdateTime");

            /// <summary>备注</summary>
            public static readonly Field Remark = FindByName("Remark");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得产品字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String ID = "ID";

            /// <summary>团队</summary>
            public const String TeamId = "TeamId";

            /// <summary>名称</summary>
            public const String Name = "Name";

            /// <summary>类型</summary>
            public const String Kind = "Kind";

            /// <summary>负责人</summary>
            public const String LeaderId = "LeaderId";

            /// <summary>启用</summary>
            public const String Enable = "Enable";

            /// <summary>版本数</summary>
            public const String Versions = "Versions";

            /// <summary>故事数</summary>
            public const String Stories = "Stories";

            /// <summary>完成</summary>
            public const String Completed = "Completed";

            /// <summary>创建者</summary>
            public const String CreateUser = "CreateUser";

            /// <summary>创建人</summary>
            public const String CreateUserID = "CreateUserID";

            /// <summary>创建地址</summary>
            public const String CreateIP = "CreateIP";

            /// <summary>创建时间</summary>
            public const String CreateTime = "CreateTime";

            /// <summary>更新者</summary>
            public const String UpdateUser = "UpdateUser";

            /// <summary>更新人</summary>
            public const String UpdateUserID = "UpdateUserID";

            /// <summary>更新地址</summary>
            public const String UpdateIP = "UpdateIP";

            /// <summary>更新时间</summary>
            public const String UpdateTime = "UpdateTime";

            /// <summary>备注</summary>
            public const String Remark = "Remark";
        }
        #endregion
    }

    /// <summary>产品接口</summary>
    public partial interface IProduct
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 ID { get; set; }

        /// <summary>团队</summary>
        Int32 TeamId { get; set; }

        /// <summary>名称</summary>
        String Name { get; set; }

        /// <summary>类型</summary>
        String Kind { get; set; }

        /// <summary>负责人</summary>
        Int32 LeaderId { get; set; }

        /// <summary>启用</summary>
        Boolean Enable { get; set; }

        /// <summary>版本数</summary>
        Int32 Versions { get; set; }

        /// <summary>故事数</summary>
        Int32 Stories { get; set; }

        /// <summary>完成</summary>
        Boolean Completed { get; set; }

        /// <summary>创建者</summary>
        String CreateUser { get; set; }

        /// <summary>创建人</summary>
        Int32 CreateUserID { get; set; }

        /// <summary>创建地址</summary>
        String CreateIP { get; set; }

        /// <summary>创建时间</summary>
        DateTime CreateTime { get; set; }

        /// <summary>更新者</summary>
        String UpdateUser { get; set; }

        /// <summary>更新人</summary>
        Int32 UpdateUserID { get; set; }

        /// <summary>更新地址</summary>
        String UpdateIP { get; set; }

        /// <summary>更新时间</summary>
        DateTime UpdateTime { get; set; }

        /// <summary>备注</summary>
        String Remark { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}
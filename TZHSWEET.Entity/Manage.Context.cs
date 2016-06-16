﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码是根据模板生成的。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace TZHSWEET.Entity
{
    public partial class BaseManageEntities : ObjectContext
    {
        public const string ConnectionString = "name=BaseManageEntities";
        public const string ContainerName = "BaseManageEntities";
    
        #region Constructors
    
        public BaseManageEntities()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public BaseManageEntities(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public BaseManageEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // 创建代理需要使用 ProxyDataContractResolver 和
            // 可允许延迟加载，这可以在序列化期间展开加载图。
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet 属性
    
        public ObjectSet<PM_Approve> PM_Approve
        {
            get { return _pM_Approve  ?? (_pM_Approve = CreateObjectSet<PM_Approve>("PM_Approve")); }
        }
        private ObjectSet<PM_Approve> _pM_Approve;
    
        public ObjectSet<PM_Category> PM_Category
        {
            get { return _pM_Category  ?? (_pM_Category = CreateObjectSet<PM_Category>("PM_Category")); }
        }
        private ObjectSet<PM_Category> _pM_Category;
    
        public ObjectSet<PM_Contract> PM_Contract
        {
            get { return _pM_Contract  ?? (_pM_Contract = CreateObjectSet<PM_Contract>("PM_Contract")); }
        }
        private ObjectSet<PM_Contract> _pM_Contract;
    
        public ObjectSet<PM_Department> PM_Department
        {
            get { return _pM_Department  ?? (_pM_Department = CreateObjectSet<PM_Department>("PM_Department")); }
        }
        private ObjectSet<PM_Department> _pM_Department;
    
        public ObjectSet<PM_Directorys> PM_Directorys
        {
            get { return _pM_Directorys  ?? (_pM_Directorys = CreateObjectSet<PM_Directorys>("PM_Directorys")); }
        }
        private ObjectSet<PM_Directorys> _pM_Directorys;
    
        public ObjectSet<PM_FlowLog> PM_FlowLog
        {
            get { return _pM_FlowLog  ?? (_pM_FlowLog = CreateObjectSet<PM_FlowLog>("PM_FlowLog")); }
        }
        private ObjectSet<PM_FlowLog> _pM_FlowLog;
    
        public ObjectSet<PM_Member> PM_Member
        {
            get { return _pM_Member  ?? (_pM_Member = CreateObjectSet<PM_Member>("PM_Member")); }
        }
        private ObjectSet<PM_Member> _pM_Member;
    
        public ObjectSet<PM_ProgressLog> PM_ProgressLog
        {
            get { return _pM_ProgressLog  ?? (_pM_ProgressLog = CreateObjectSet<PM_ProgressLog>("PM_ProgressLog")); }
        }
        private ObjectSet<PM_ProgressLog> _pM_ProgressLog;
    
        public ObjectSet<PM_Project> PM_Project
        {
            get { return _pM_Project  ?? (_pM_Project = CreateObjectSet<PM_Project>("PM_Project")); }
        }
        private ObjectSet<PM_Project> _pM_Project;
    
        public ObjectSet<PM_Task> PM_Task
        {
            get { return _pM_Task  ?? (_pM_Task = CreateObjectSet<PM_Task>("PM_Task")); }
        }
        private ObjectSet<PM_Task> _pM_Task;
    
        public ObjectSet<PM_Workload> PM_Workload
        {
            get { return _pM_Workload  ?? (_pM_Workload = CreateObjectSet<PM_Workload>("PM_Workload")); }
        }
        private ObjectSet<PM_Workload> _pM_Workload;
    
        public ObjectSet<sysdiagram> sysdiagrams
        {
            get { return _sysdiagrams  ?? (_sysdiagrams = CreateObjectSet<sysdiagram>("sysdiagrams")); }
        }
        private ObjectSet<sysdiagram> _sysdiagrams;
    
        public ObjectSet<tbDepartment> tbDepartments
        {
            get { return _tbDepartments  ?? (_tbDepartments = CreateObjectSet<tbDepartment>("tbDepartments")); }
        }
        private ObjectSet<tbDepartment> _tbDepartments;
    
        public ObjectSet<tbFavorite> tbFavorites
        {
            get { return _tbFavorites  ?? (_tbFavorites = CreateObjectSet<tbFavorite>("tbFavorites")); }
        }
        private ObjectSet<tbFavorite> _tbFavorites;
    
        public ObjectSet<tbModule> tbModules
        {
            get { return _tbModules  ?? (_tbModules = CreateObjectSet<tbModule>("tbModules")); }
        }
        private ObjectSet<tbModule> _tbModules;
    
        public ObjectSet<tbModulePermission> tbModulePermissions
        {
            get { return _tbModulePermissions  ?? (_tbModulePermissions = CreateObjectSet<tbModulePermission>("tbModulePermissions")); }
        }
        private ObjectSet<tbModulePermission> _tbModulePermissions;
    
        public ObjectSet<tbOperateLog> tbOperateLogs
        {
            get { return _tbOperateLogs  ?? (_tbOperateLogs = CreateObjectSet<tbOperateLog>("tbOperateLogs")); }
        }
        private ObjectSet<tbOperateLog> _tbOperateLogs;
    
        public ObjectSet<tbPermission> tbPermissions
        {
            get { return _tbPermissions  ?? (_tbPermissions = CreateObjectSet<tbPermission>("tbPermissions")); }
        }
        private ObjectSet<tbPermission> _tbPermissions;
    
        public ObjectSet<tbRole> tbRoles
        {
            get { return _tbRoles  ?? (_tbRoles = CreateObjectSet<tbRole>("tbRoles")); }
        }
        private ObjectSet<tbRole> _tbRoles;
    
        public ObjectSet<tbRolePermission> tbRolePermissions
        {
            get { return _tbRolePermissions  ?? (_tbRolePermissions = CreateObjectSet<tbRolePermission>("tbRolePermissions")); }
        }
        private ObjectSet<tbRolePermission> _tbRolePermissions;
    
        public ObjectSet<tbUser> tbUsers
        {
            get { return _tbUsers  ?? (_tbUsers = CreateObjectSet<tbUser>("tbUsers")); }
        }
        private ObjectSet<tbUser> _tbUsers;
    
        public ObjectSet<tbUserRole> tbUserRoles
        {
            get { return _tbUserRoles  ?? (_tbUserRoles = CreateObjectSet<tbUserRole>("tbUserRoles")); }
        }
        private ObjectSet<tbUserRole> _tbUserRoles;
    
        public ObjectSet<VModulePermission> VModulePermissions
        {
            get { return _vModulePermissions  ?? (_vModulePermissions = CreateObjectSet<VModulePermission>("VModulePermissions")); }
        }
        private ObjectSet<VModulePermission> _vModulePermissions;
    
        public ObjectSet<VRoleGrantPermission> VRoleGrantPermissions
        {
            get { return _vRoleGrantPermissions  ?? (_vRoleGrantPermissions = CreateObjectSet<VRoleGrantPermission>("VRoleGrantPermissions")); }
        }
        private ObjectSet<VRoleGrantPermission> _vRoleGrantPermissions;
    
        public ObjectSet<VRoleMenuPermission> VRoleMenuPermissions
        {
            get { return _vRoleMenuPermissions  ?? (_vRoleMenuPermissions = CreateObjectSet<VRoleMenuPermission>("VRoleMenuPermissions")); }
        }
        private ObjectSet<VRoleMenuPermission> _vRoleMenuPermissions;
    
        public ObjectSet<VRoleModulePermission> VRoleModulePermissions
        {
            get { return _vRoleModulePermissions  ?? (_vRoleModulePermissions = CreateObjectSet<VRoleModulePermission>("VRoleModulePermissions")); }
        }
        private ObjectSet<VRoleModulePermission> _vRoleModulePermissions;
    
        public ObjectSet<VRolePermission> VRolePermissions
        {
            get { return _vRolePermissions  ?? (_vRolePermissions = CreateObjectSet<VRolePermission>("VRolePermissions")); }
        }
        private ObjectSet<VRolePermission> _vRolePermissions;
    
        public ObjectSet<PM_Documents> PM_Documents
        {
            get { return _pM_Documents  ?? (_pM_Documents = CreateObjectSet<PM_Documents>("PM_Documents")); }
        }
        private ObjectSet<PM_Documents> _pM_Documents;
    
        public ObjectSet<PM_Attachment> PM_Attachment
        {
            get { return _pM_Attachment  ?? (_pM_Attachment = CreateObjectSet<PM_Attachment>("PM_Attachment")); }
        }
        private ObjectSet<PM_Attachment> _pM_Attachment;
    
        public ObjectSet<tbDictionary> tbDictionaries
        {
            get { return _tbDictionaries  ?? (_tbDictionaries = CreateObjectSet<tbDictionary>("tbDictionaries")); }
        }
        private ObjectSet<tbDictionary> _tbDictionaries;
    
        public ObjectSet<PM_Customer> PM_Customer
        {
            get { return _pM_Customer  ?? (_pM_Customer = CreateObjectSet<PM_Customer>("PM_Customer")); }
        }
        private ObjectSet<PM_Customer> _pM_Customer;
    
        public ObjectSet<PM_Staff> PM_Staff
        {
            get { return _pM_Staff  ?? (_pM_Staff = CreateObjectSet<PM_Staff>("PM_Staff")); }
        }
        private ObjectSet<PM_Staff> _pM_Staff;
    
        public ObjectSet<VModuleProject> VModuleProjects
        {
            get { return _vModuleProjects  ?? (_vModuleProjects = CreateObjectSet<VModuleProject>("VModuleProjects")); }
        }
        private ObjectSet<VModuleProject> _vModuleProjects;
    
        public ObjectSet<ViewTask> ViewTasks
        {
            get { return _viewTasks  ?? (_viewTasks = CreateObjectSet<ViewTask>("ViewTasks")); }
        }
        private ObjectSet<ViewTask> _viewTasks;

        #endregion

    }
}

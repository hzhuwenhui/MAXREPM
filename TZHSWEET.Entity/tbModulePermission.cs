//------------------------------------------------------------------------------
// <auto-generated>
//     此代码是根据模板生成的。
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace TZHSWEET.Entity
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(tbModule))]
    [KnownType(typeof(tbPermission))]
    [KnownType(typeof(tbRolePermission))]
    public partial class tbModulePermission: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基元属性
    
        [DataMember]
        public long ModulePermissionID
        {
            get { return _modulePermissionID; }
            set
            {
                if (_modulePermissionID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("属性“ModulePermissionID”是对象键的一部分，不可更改。仅当未跟踪对象或对象处于“已添加”状态时，才能对键属性进行更改。");
                    }
                    _modulePermissionID = value;
                    OnPropertyChanged("ModulePermissionID");
                }
            }
        }
        private long _modulePermissionID;
    
        [DataMember]
        public Nullable<int> ModuleID
        {
            get { return _moduleID; }
            set
            {
                if (_moduleID != value)
                {
                    ChangeTracker.RecordOriginalValue("ModuleID", _moduleID);
                    if (!IsDeserializing)
                    {
                        if (tbModule != null && tbModule.ModuleID != value)
                        {
                            tbModule = null;
                        }
                    }
                    _moduleID = value;
                    OnPropertyChanged("ModuleID");
                }
            }
        }
        private Nullable<int> _moduleID;
    
        [DataMember]
        public Nullable<int> PermissionID
        {
            get { return _permissionID; }
            set
            {
                if (_permissionID != value)
                {
                    ChangeTracker.RecordOriginalValue("PermissionID", _permissionID);
                    if (!IsDeserializing)
                    {
                        if (tbPermission != null && tbPermission.PermissionID != value)
                        {
                            tbPermission = null;
                        }
                    }
                    _permissionID = value;
                    OnPropertyChanged("PermissionID");
                }
            }
        }
        private Nullable<int> _permissionID;
    
        [DataMember]
        public Nullable<int> CreateUserID
        {
            get { return _createUserID; }
            set
            {
                if (_createUserID != value)
                {
                    _createUserID = value;
                    OnPropertyChanged("CreateUserID");
                }
            }
        }
        private Nullable<int> _createUserID;
    
        [DataMember]
        public Nullable<System.DateTime> CreateDate
        {
            get { return _createDate; }
            set
            {
                if (_createDate != value)
                {
                    _createDate = value;
                    OnPropertyChanged("CreateDate");
                }
            }
        }
        private Nullable<System.DateTime> _createDate;
    
        [DataMember]
        public Nullable<int> ModifyUserID
        {
            get { return _modifyUserID; }
            set
            {
                if (_modifyUserID != value)
                {
                    _modifyUserID = value;
                    OnPropertyChanged("ModifyUserID");
                }
            }
        }
        private Nullable<int> _modifyUserID;
    
        [DataMember]
        public Nullable<System.DateTime> ModifyDate
        {
            get { return _modifyDate; }
            set
            {
                if (_modifyDate != value)
                {
                    _modifyDate = value;
                    OnPropertyChanged("ModifyDate");
                }
            }
        }
        private Nullable<System.DateTime> _modifyDate;
    
        [DataMember]
        public string RecordStatus
        {
            get { return _recordStatus; }
            set
            {
                if (_recordStatus != value)
                {
                    _recordStatus = value;
                    OnPropertyChanged("RecordStatus");
                }
            }
        }
        private string _recordStatus;
    
        [DataMember]
        public Nullable<bool> IsDeleted
        {
            get { return _isDeleted; }
            set
            {
                if (_isDeleted != value)
                {
                    _isDeleted = value;
                    OnPropertyChanged("IsDeleted");
                }
            }
        }
        private Nullable<bool> _isDeleted;

        #endregion

        #region 导航属性
    
        [DataMember]
        public tbModule tbModule
        {
            get { return _tbModule; }
            set
            {
                if (!ReferenceEquals(_tbModule, value))
                {
                    var previousValue = _tbModule;
                    _tbModule = value;
                    FixuptbModule(previousValue);
                    OnNavigationPropertyChanged("tbModule");
                }
            }
        }
        private tbModule _tbModule;
    
        [DataMember]
        public tbPermission tbPermission
        {
            get { return _tbPermission; }
            set
            {
                if (!ReferenceEquals(_tbPermission, value))
                {
                    var previousValue = _tbPermission;
                    _tbPermission = value;
                    FixuptbPermission(previousValue);
                    OnNavigationPropertyChanged("tbPermission");
                }
            }
        }
        private tbPermission _tbPermission;
    
        [DataMember]
        public TrackableCollection<tbRolePermission> tbRolePermissions
        {
            get
            {
                if (_tbRolePermissions == null)
                {
                    _tbRolePermissions = new TrackableCollection<tbRolePermission>();
                    _tbRolePermissions.CollectionChanged += FixuptbRolePermissions;
                }
                return _tbRolePermissions;
            }
            set
            {
                if (!ReferenceEquals(_tbRolePermissions, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("当启用 ChangeTracking 时，无法设置 FixupChangeTrackingCollection");
                    }
                    if (_tbRolePermissions != null)
                    {
                        _tbRolePermissions.CollectionChanged -= FixuptbRolePermissions;
                    }
                    _tbRolePermissions = value;
                    if (_tbRolePermissions != null)
                    {
                        _tbRolePermissions.CollectionChanged += FixuptbRolePermissions;
                    }
                    OnNavigationPropertyChanged("tbRolePermissions");
                }
            }
        }
        private TrackableCollection<tbRolePermission> _tbRolePermissions;

        #endregion

        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
            tbModule = null;
            tbPermission = null;
            tbRolePermissions.Clear();
        }

        #endregion

        #region 关联修复
    
        private void FixuptbModule(tbModule previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.tbModulePermissions.Contains(this))
            {
                previousValue.tbModulePermissions.Remove(this);
            }
    
            if (tbModule != null)
            {
                if (!tbModule.tbModulePermissions.Contains(this))
                {
                    tbModule.tbModulePermissions.Add(this);
                }
    
                ModuleID = tbModule.ModuleID;
            }
            else if (!skipKeys)
            {
                ModuleID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("tbModule")
                    && (ChangeTracker.OriginalValues["tbModule"] == tbModule))
                {
                    ChangeTracker.OriginalValues.Remove("tbModule");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("tbModule", previousValue);
                }
                if (tbModule != null && !tbModule.ChangeTracker.ChangeTrackingEnabled)
                {
                    tbModule.StartTracking();
                }
            }
        }
    
        private void FixuptbPermission(tbPermission previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.tbModulePermissions.Contains(this))
            {
                previousValue.tbModulePermissions.Remove(this);
            }
    
            if (tbPermission != null)
            {
                if (!tbPermission.tbModulePermissions.Contains(this))
                {
                    tbPermission.tbModulePermissions.Add(this);
                }
    
                PermissionID = tbPermission.PermissionID;
            }
            else if (!skipKeys)
            {
                PermissionID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("tbPermission")
                    && (ChangeTracker.OriginalValues["tbPermission"] == tbPermission))
                {
                    ChangeTracker.OriginalValues.Remove("tbPermission");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("tbPermission", previousValue);
                }
                if (tbPermission != null && !tbPermission.ChangeTracker.ChangeTrackingEnabled)
                {
                    tbPermission.StartTracking();
                }
            }
        }
    
        private void FixuptbRolePermissions(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (tbRolePermission item in e.NewItems)
                {
                    item.tbModulePermission = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("tbRolePermissions", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (tbRolePermission item in e.OldItems)
                {
                    if (ReferenceEquals(item.tbModulePermission, this))
                    {
                        item.tbModulePermission = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("tbRolePermissions", item);
                    }
                }
            }
        }

        #endregion

    }
}

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
    [KnownType(typeof(tbDepartment))]
    [KnownType(typeof(tbFavorite))]
    [KnownType(typeof(tbUserRole))]
    public partial class tbUser: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基元属性
    
        [DataMember]
        public int UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("属性“UserID”是对象键的一部分，不可更改。仅当未跟踪对象或对象处于“已添加”状态时，才能对键属性进行更改。");
                    }
                    _userID = value;
                    OnPropertyChanged("UserID");
                }
            }
        }
        private int _userID;
    
        [DataMember]
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    OnPropertyChanged("UserName");
                }
            }
        }
        private string _userName;
    
        [DataMember]
        public string UserPassword
        {
            get { return _userPassword; }
            set
            {
                if (_userPassword != value)
                {
                    _userPassword = value;
                    OnPropertyChanged("UserPassword");
                }
            }
        }
        private string _userPassword;
    
        [DataMember]
        public Nullable<int> RoleID
        {
            get { return _roleID; }
            set
            {
                if (_roleID != value)
                {
                    _roleID = value;
                    OnPropertyChanged("RoleID");
                }
            }
        }
        private Nullable<int> _roleID;
    
        [DataMember]
        public Nullable<int> DeptID
        {
            get { return _deptID; }
            set
            {
                if (_deptID != value)
                {
                    ChangeTracker.RecordOriginalValue("DeptID", _deptID);
                    if (!IsDeserializing)
                    {
                        if (tbDepartment != null && tbDepartment.DeptID != value)
                        {
                            tbDepartment = null;
                        }
                    }
                    _deptID = value;
                    OnPropertyChanged("DeptID");
                }
            }
        }
        private Nullable<int> _deptID;
    
        [DataMember]
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (_phone != value)
                {
                    _phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }
        private string _phone;
    
        [DataMember]
        public string Fax
        {
            get { return _fax; }
            set
            {
                if (_fax != value)
                {
                    _fax = value;
                    OnPropertyChanged("Fax");
                }
            }
        }
        private string _fax;
    
        [DataMember]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        private string _email;
    
        [DataMember]
        public string QQ
        {
            get { return _qQ; }
            set
            {
                if (_qQ != value)
                {
                    _qQ = value;
                    OnPropertyChanged("QQ");
                }
            }
        }
        private string _qQ;
    
        [DataMember]
        public string NickName
        {
            get { return _nickName; }
            set
            {
                if (_nickName != value)
                {
                    _nickName = value;
                    OnPropertyChanged("NickName");
                }
            }
        }
        private string _nickName;
    
        [DataMember]
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        private string _address;
    
        [DataMember]
        public string RealName
        {
            get { return _realName; }
            set
            {
                if (_realName != value)
                {
                    _realName = value;
                    OnPropertyChanged("RealName");
                }
            }
        }
        private string _realName;
    
        [DataMember]
        public Nullable<bool> Sex
        {
            get { return _sex; }
            set
            {
                if (_sex != value)
                {
                    _sex = value;
                    OnPropertyChanged("Sex");
                }
            }
        }
        private Nullable<bool> _sex;
    
        [DataMember]
        public Nullable<bool> Enabled
        {
            get { return _enabled; }
            set
            {
                if (_enabled != value)
                {
                    _enabled = value;
                    OnPropertyChanged("Enabled");
                }
            }
        }
        private Nullable<bool> _enabled;
    
        [DataMember]
        public Nullable<System.DateTime> LastLoginTime
        {
            get { return _lastLoginTime; }
            set
            {
                if (_lastLoginTime != value)
                {
                    _lastLoginTime = value;
                    OnPropertyChanged("LastLoginTime");
                }
            }
        }
        private Nullable<System.DateTime> _lastLoginTime;
    
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
        public tbDepartment tbDepartment
        {
            get { return _tbDepartment; }
            set
            {
                if (!ReferenceEquals(_tbDepartment, value))
                {
                    var previousValue = _tbDepartment;
                    _tbDepartment = value;
                    FixuptbDepartment(previousValue);
                    OnNavigationPropertyChanged("tbDepartment");
                }
            }
        }
        private tbDepartment _tbDepartment;
    
        [DataMember]
        public TrackableCollection<tbFavorite> tbFavorites
        {
            get
            {
                if (_tbFavorites == null)
                {
                    _tbFavorites = new TrackableCollection<tbFavorite>();
                    _tbFavorites.CollectionChanged += FixuptbFavorites;
                }
                return _tbFavorites;
            }
            set
            {
                if (!ReferenceEquals(_tbFavorites, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("当启用 ChangeTracking 时，无法设置 FixupChangeTrackingCollection");
                    }
                    if (_tbFavorites != null)
                    {
                        _tbFavorites.CollectionChanged -= FixuptbFavorites;
                    }
                    _tbFavorites = value;
                    if (_tbFavorites != null)
                    {
                        _tbFavorites.CollectionChanged += FixuptbFavorites;
                    }
                    OnNavigationPropertyChanged("tbFavorites");
                }
            }
        }
        private TrackableCollection<tbFavorite> _tbFavorites;
    
        [DataMember]
        public TrackableCollection<tbUserRole> tbUserRoles
        {
            get
            {
                if (_tbUserRoles == null)
                {
                    _tbUserRoles = new TrackableCollection<tbUserRole>();
                    _tbUserRoles.CollectionChanged += FixuptbUserRoles;
                }
                return _tbUserRoles;
            }
            set
            {
                if (!ReferenceEquals(_tbUserRoles, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("当启用 ChangeTracking 时，无法设置 FixupChangeTrackingCollection");
                    }
                    if (_tbUserRoles != null)
                    {
                        _tbUserRoles.CollectionChanged -= FixuptbUserRoles;
                    }
                    _tbUserRoles = value;
                    if (_tbUserRoles != null)
                    {
                        _tbUserRoles.CollectionChanged += FixuptbUserRoles;
                    }
                    OnNavigationPropertyChanged("tbUserRoles");
                }
            }
        }
        private TrackableCollection<tbUserRole> _tbUserRoles;

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
            tbDepartment = null;
            tbFavorites.Clear();
            tbUserRoles.Clear();
        }

        #endregion

        #region 关联修复
    
        private void FixuptbDepartment(tbDepartment previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.tbUsers.Contains(this))
            {
                previousValue.tbUsers.Remove(this);
            }
    
            if (tbDepartment != null)
            {
                if (!tbDepartment.tbUsers.Contains(this))
                {
                    tbDepartment.tbUsers.Add(this);
                }
    
                DeptID = tbDepartment.DeptID;
            }
            else if (!skipKeys)
            {
                DeptID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("tbDepartment")
                    && (ChangeTracker.OriginalValues["tbDepartment"] == tbDepartment))
                {
                    ChangeTracker.OriginalValues.Remove("tbDepartment");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("tbDepartment", previousValue);
                }
                if (tbDepartment != null && !tbDepartment.ChangeTracker.ChangeTrackingEnabled)
                {
                    tbDepartment.StartTracking();
                }
            }
        }
    
        private void FixuptbFavorites(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (tbFavorite item in e.NewItems)
                {
                    item.tbUser = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("tbFavorites", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (tbFavorite item in e.OldItems)
                {
                    if (ReferenceEquals(item.tbUser, this))
                    {
                        item.tbUser = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("tbFavorites", item);
                    }
                }
            }
        }
    
        private void FixuptbUserRoles(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (tbUserRole item in e.NewItems)
                {
                    item.tbUser = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("tbUserRoles", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (tbUserRole item in e.OldItems)
                {
                    if (ReferenceEquals(item.tbUser, this))
                    {
                        item.tbUser = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("tbUserRoles", item);
                    }
                }
            }
        }

        #endregion

    }
}
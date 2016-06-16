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
    [KnownType(typeof(PM_Project))]
    public partial class PM_Approve: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基元属性
    
        [DataMember]
        public int ID
        {
            get { return _iD; }
            set
            {
                if (_iD != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("属性“ID”是对象键的一部分，不可更改。仅当未跟踪对象或对象处于“已添加”状态时，才能对键属性进行更改。");
                    }
                    _iD = value;
                    OnPropertyChanged("ID");
                }
            }
        }
        private int _iD;
    
        [DataMember]
        public Nullable<int> ProjectID
        {
            get { return _projectID; }
            set
            {
                if (_projectID != value)
                {
                    ChangeTracker.RecordOriginalValue("ProjectID", _projectID);
                    if (!IsDeserializing)
                    {
                        if (PM_Project != null && PM_Project.ID != value)
                        {
                            PM_Project = null;
                        }
                    }
                    _projectID = value;
                    OnPropertyChanged("ProjectID");
                }
            }
        }
        private Nullable<int> _projectID;
    
        [DataMember]
        public Nullable<int> ApproveUserID
        {
            get { return _approveUserID; }
            set
            {
                if (_approveUserID != value)
                {
                    _approveUserID = value;
                    OnPropertyChanged("ApproveUserID");
                }
            }
        }
        private Nullable<int> _approveUserID;
    
        [DataMember]
        public Nullable<System.DateTime> ApproveDate
        {
            get { return _approveDate; }
            set
            {
                if (_approveDate != value)
                {
                    _approveDate = value;
                    OnPropertyChanged("ApproveDate");
                }
            }
        }
        private Nullable<System.DateTime> _approveDate;
    
        [DataMember]
        public Nullable<int> ApproveState
        {
            get { return _approveState; }
            set
            {
                if (_approveState != value)
                {
                    _approveState = value;
                    OnPropertyChanged("ApproveState");
                }
            }
        }
        private Nullable<int> _approveState;
    
        [DataMember]
        public string ApproveComments
        {
            get { return _approveComments; }
            set
            {
                if (_approveComments != value)
                {
                    _approveComments = value;
                    OnPropertyChanged("ApproveComments");
                }
            }
        }
        private string _approveComments;
    
        [DataMember]
        public Nullable<int> ApproveType
        {
            get { return _approveType; }
            set
            {
                if (_approveType != value)
                {
                    _approveType = value;
                    OnPropertyChanged("ApproveType");
                }
            }
        }
        private Nullable<int> _approveType;
    
        [DataMember]
        public Nullable<int> ApplyUserID
        {
            get { return _applyUserID; }
            set
            {
                if (_applyUserID != value)
                {
                    _applyUserID = value;
                    OnPropertyChanged("ApplyUserID");
                }
            }
        }
        private Nullable<int> _applyUserID;
    
        [DataMember]
        public Nullable<System.DateTime> ApplyDate
        {
            get { return _applyDate; }
            set
            {
                if (_applyDate != value)
                {
                    _applyDate = value;
                    OnPropertyChanged("ApplyDate");
                }
            }
        }
        private Nullable<System.DateTime> _applyDate;

        #endregion

        #region 导航属性
    
        [DataMember]
        public PM_Project PM_Project
        {
            get { return _pM_Project; }
            set
            {
                if (!ReferenceEquals(_pM_Project, value))
                {
                    var previousValue = _pM_Project;
                    _pM_Project = value;
                    FixupPM_Project(previousValue);
                    OnNavigationPropertyChanged("PM_Project");
                }
            }
        }
        private PM_Project _pM_Project;

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
            PM_Project = null;
        }

        #endregion

        #region 关联修复
    
        private void FixupPM_Project(PM_Project previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PM_Approve.Contains(this))
            {
                previousValue.PM_Approve.Remove(this);
            }
    
            if (PM_Project != null)
            {
                if (!PM_Project.PM_Approve.Contains(this))
                {
                    PM_Project.PM_Approve.Add(this);
                }
    
                ProjectID = PM_Project.ID;
            }
            else if (!skipKeys)
            {
                ProjectID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("PM_Project")
                    && (ChangeTracker.OriginalValues["PM_Project"] == PM_Project))
                {
                    ChangeTracker.OriginalValues.Remove("PM_Project");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("PM_Project", previousValue);
                }
                if (PM_Project != null && !PM_Project.ChangeTracker.ChangeTrackingEnabled)
                {
                    PM_Project.StartTracking();
                }
            }
        }

        #endregion

    }
}

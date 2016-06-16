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
    [KnownType(typeof(PM_Directorys))]
    [KnownType(typeof(PM_Task))]
    public partial class PM_Documents: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基元属性
    
        [DataMember]
        public int DocID
        {
            get { return _docID; }
            set
            {
                if (_docID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("属性“DocID”是对象键的一部分，不可更改。仅当未跟踪对象或对象处于“已添加”状态时，才能对键属性进行更改。");
                    }
                    _docID = value;
                    OnPropertyChanged("DocID");
                }
            }
        }
        private int _docID;
    
        [DataMember]
        public Nullable<int> ProjectID
        {
            get { return _projectID; }
            set
            {
                if (_projectID != value)
                {
                    _projectID = value;
                    OnPropertyChanged("ProjectID");
                }
            }
        }
        private Nullable<int> _projectID;
    
        [DataMember]
        public Nullable<int> TaskID
        {
            get { return _taskID; }
            set
            {
                if (_taskID != value)
                {
                    ChangeTracker.RecordOriginalValue("TaskID", _taskID);
                    if (!IsDeserializing)
                    {
                        if (PM_Task != null && PM_Task.ID != value)
                        {
                            PM_Task = null;
                        }
                    }
                    _taskID = value;
                    OnPropertyChanged("TaskID");
                }
            }
        }
        private Nullable<int> _taskID;
    
        [DataMember]
        public string DocTitle
        {
            get { return _docTitle; }
            set
            {
                if (_docTitle != value)
                {
                    _docTitle = value;
                    OnPropertyChanged("DocTitle");
                }
            }
        }
        private string _docTitle;
    
        [DataMember]
        public Nullable<int> DocType
        {
            get { return _docType; }
            set
            {
                if (_docType != value)
                {
                    _docType = value;
                    OnPropertyChanged("DocType");
                }
            }
        }
        private Nullable<int> _docType;
    
        [DataMember]
        public string DocPath
        {
            get { return _docPath; }
            set
            {
                if (_docPath != value)
                {
                    _docPath = value;
                    OnPropertyChanged("DocPath");
                }
            }
        }
        private string _docPath;
    
        [DataMember]
        public string DocContext
        {
            get { return _docContext; }
            set
            {
                if (_docContext != value)
                {
                    _docContext = value;
                    OnPropertyChanged("DocContext");
                }
            }
        }
        private string _docContext;
    
        [DataMember]
        public string DocRemark
        {
            get { return _docRemark; }
            set
            {
                if (_docRemark != value)
                {
                    _docRemark = value;
                    OnPropertyChanged("DocRemark");
                }
            }
        }
        private string _docRemark;
    
        [DataMember]
        public Nullable<System.DateTime> LastViewDate
        {
            get { return _lastViewDate; }
            set
            {
                if (_lastViewDate != value)
                {
                    _lastViewDate = value;
                    OnPropertyChanged("LastViewDate");
                }
            }
        }
        private Nullable<System.DateTime> _lastViewDate;
    
        [DataMember]
        public Nullable<int> LastViewUserID
        {
            get { return _lastViewUserID; }
            set
            {
                if (_lastViewUserID != value)
                {
                    _lastViewUserID = value;
                    OnPropertyChanged("LastViewUserID");
                }
            }
        }
        private Nullable<int> _lastViewUserID;
    
        [DataMember]
        public Nullable<int> ViewCount
        {
            get { return _viewCount; }
            set
            {
                if (_viewCount != value)
                {
                    _viewCount = value;
                    OnPropertyChanged("ViewCount");
                }
            }
        }
        private Nullable<int> _viewCount;
    
        [DataMember]
        public string FromSource
        {
            get { return _fromSource; }
            set
            {
                if (_fromSource != value)
                {
                    _fromSource = value;
                    OnPropertyChanged("FromSource");
                }
            }
        }
        private string _fromSource;
    
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
    
        [DataMember]
        public Nullable<bool> IsShare
        {
            get { return _isShare; }
            set
            {
                if (_isShare != value)
                {
                    _isShare = value;
                    OnPropertyChanged("IsShare");
                }
            }
        }
        private Nullable<bool> _isShare;
    
        [DataMember]
        public Nullable<int> DirectoryID
        {
            get { return _directoryID; }
            set
            {
                if (_directoryID != value)
                {
                    ChangeTracker.RecordOriginalValue("DirectoryID", _directoryID);
                    if (!IsDeserializing)
                    {
                        if (PM_Directorys != null && PM_Directorys.DirectoryID != value)
                        {
                            PM_Directorys = null;
                        }
                    }
                    _directoryID = value;
                    OnPropertyChanged("DirectoryID");
                }
            }
        }
        private Nullable<int> _directoryID;

        #endregion

        #region 导航属性
    
        [DataMember]
        public PM_Directorys PM_Directorys
        {
            get { return _pM_Directorys; }
            set
            {
                if (!ReferenceEquals(_pM_Directorys, value))
                {
                    var previousValue = _pM_Directorys;
                    _pM_Directorys = value;
                    FixupPM_Directorys(previousValue);
                    OnNavigationPropertyChanged("PM_Directorys");
                }
            }
        }
        private PM_Directorys _pM_Directorys;
    
        [DataMember]
        public PM_Task PM_Task
        {
            get { return _pM_Task; }
            set
            {
                if (!ReferenceEquals(_pM_Task, value))
                {
                    var previousValue = _pM_Task;
                    _pM_Task = value;
                    FixupPM_Task(previousValue);
                    OnNavigationPropertyChanged("PM_Task");
                }
            }
        }
        private PM_Task _pM_Task;

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
            PM_Directorys = null;
            PM_Task = null;
        }

        #endregion

        #region 关联修复
    
        private void FixupPM_Directorys(PM_Directorys previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PM_Documents.Contains(this))
            {
                previousValue.PM_Documents.Remove(this);
            }
    
            if (PM_Directorys != null)
            {
                if (!PM_Directorys.PM_Documents.Contains(this))
                {
                    PM_Directorys.PM_Documents.Add(this);
                }
    
                DirectoryID = PM_Directorys.DirectoryID;
            }
            else if (!skipKeys)
            {
                DirectoryID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("PM_Directorys")
                    && (ChangeTracker.OriginalValues["PM_Directorys"] == PM_Directorys))
                {
                    ChangeTracker.OriginalValues.Remove("PM_Directorys");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("PM_Directorys", previousValue);
                }
                if (PM_Directorys != null && !PM_Directorys.ChangeTracker.ChangeTrackingEnabled)
                {
                    PM_Directorys.StartTracking();
                }
            }
        }
    
        private void FixupPM_Task(PM_Task previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PM_Documents.Contains(this))
            {
                previousValue.PM_Documents.Remove(this);
            }
    
            if (PM_Task != null)
            {
                if (!PM_Task.PM_Documents.Contains(this))
                {
                    PM_Task.PM_Documents.Add(this);
                }
    
                TaskID = PM_Task.ID;
            }
            else if (!skipKeys)
            {
                TaskID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("PM_Task")
                    && (ChangeTracker.OriginalValues["PM_Task"] == PM_Task))
                {
                    ChangeTracker.OriginalValues.Remove("PM_Task");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("PM_Task", previousValue);
                }
                if (PM_Task != null && !PM_Task.ChangeTracker.ChangeTrackingEnabled)
                {
                    PM_Task.StartTracking();
                }
            }
        }

        #endregion

    }
}

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
    [KnownType(typeof(PM_ProgressLog))]
    [KnownType(typeof(PM_Project))]
    [KnownType(typeof(PM_Documents))]
    [KnownType(typeof(PM_Attachment))]
    public partial class PM_Task: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public Nullable<int> LeaderUserID
        {
            get { return _leaderUserID; }
            set
            {
                if (_leaderUserID != value)
                {
                    _leaderUserID = value;
                    OnPropertyChanged("LeaderUserID");
                }
            }
        }
        private Nullable<int> _leaderUserID;
    
        [DataMember]
        public string TaskProfile
        {
            get { return _taskProfile; }
            set
            {
                if (_taskProfile != value)
                {
                    _taskProfile = value;
                    OnPropertyChanged("TaskProfile");
                }
            }
        }
        private string _taskProfile;
    
        [DataMember]
        public Nullable<int> TaskState
        {
            get { return _taskState; }
            set
            {
                if (_taskState != value)
                {
                    _taskState = value;
                    OnPropertyChanged("TaskState");
                }
            }
        }
        private Nullable<int> _taskState;
    
        [DataMember]
        public Nullable<System.DateTime> TaskEndDate
        {
            get { return _taskEndDate; }
            set
            {
                if (_taskEndDate != value)
                {
                    _taskEndDate = value;
                    OnPropertyChanged("TaskEndDate");
                }
            }
        }
        private Nullable<System.DateTime> _taskEndDate;
    
        [DataMember]
        public Nullable<System.DateTime> TaskStartDate
        {
            get { return _taskStartDate; }
            set
            {
                if (_taskStartDate != value)
                {
                    _taskStartDate = value;
                    OnPropertyChanged("TaskStartDate");
                }
            }
        }
        private Nullable<System.DateTime> _taskStartDate;
    
        [DataMember]
        public Nullable<System.DateTime> DeletedDate
        {
            get { return _deletedDate; }
            set
            {
                if (_deletedDate != value)
                {
                    _deletedDate = value;
                    OnPropertyChanged("DeletedDate");
                }
            }
        }
        private Nullable<System.DateTime> _deletedDate;
    
        [DataMember]
        public Nullable<int> DeletedUserID
        {
            get { return _deletedUserID; }
            set
            {
                if (_deletedUserID != value)
                {
                    _deletedUserID = value;
                    OnPropertyChanged("DeletedUserID");
                }
            }
        }
        private Nullable<int> _deletedUserID;
    
        [DataMember]
        public Nullable<bool> IsTimeOut
        {
            get { return _isTimeOut; }
            set
            {
                if (_isTimeOut != value)
                {
                    _isTimeOut = value;
                    OnPropertyChanged("IsTimeOut");
                }
            }
        }
        private Nullable<bool> _isTimeOut;
    
        [DataMember]
        public Nullable<int> TaskLevel
        {
            get { return _taskLevel; }
            set
            {
                if (_taskLevel != value)
                {
                    _taskLevel = value;
                    OnPropertyChanged("TaskLevel");
                }
            }
        }
        private Nullable<int> _taskLevel;
    
        [DataMember]
        public Nullable<int> TaskDuration
        {
            get { return _taskDuration; }
            set
            {
                if (_taskDuration != value)
                {
                    _taskDuration = value;
                    OnPropertyChanged("TaskDuration");
                }
            }
        }
        private Nullable<int> _taskDuration;
    
        [DataMember]
        public Nullable<System.DateTime> TaskCompleteDate
        {
            get { return _taskCompleteDate; }
            set
            {
                if (_taskCompleteDate != value)
                {
                    _taskCompleteDate = value;
                    OnPropertyChanged("TaskCompleteDate");
                }
            }
        }
        private Nullable<System.DateTime> _taskCompleteDate;
    
        [DataMember]
        public Nullable<double> TaskProgress
        {
            get { return _taskProgress; }
            set
            {
                if (_taskProgress != value)
                {
                    _taskProgress = value;
                    OnPropertyChanged("TaskProgress");
                }
            }
        }
        private Nullable<double> _taskProgress;
    
        [DataMember]
        public Nullable<int> ParentID
        {
            get { return _parentID; }
            set
            {
                if (_parentID != value)
                {
                    _parentID = value;
                    OnPropertyChanged("ParentID");
                }
            }
        }
        private Nullable<int> _parentID;
    
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
        public string TaskName
        {
            get { return _taskName; }
            set
            {
                if (_taskName != value)
                {
                    _taskName = value;
                    OnPropertyChanged("TaskName");
                }
            }
        }
        private string _taskName;

        #endregion

        #region 导航属性
    
        [DataMember]
        public TrackableCollection<PM_ProgressLog> PM_ProgressLog
        {
            get
            {
                if (_pM_ProgressLog == null)
                {
                    _pM_ProgressLog = new TrackableCollection<PM_ProgressLog>();
                    _pM_ProgressLog.CollectionChanged += FixupPM_ProgressLog;
                }
                return _pM_ProgressLog;
            }
            set
            {
                if (!ReferenceEquals(_pM_ProgressLog, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("当启用 ChangeTracking 时，无法设置 FixupChangeTrackingCollection");
                    }
                    if (_pM_ProgressLog != null)
                    {
                        _pM_ProgressLog.CollectionChanged -= FixupPM_ProgressLog;
                    }
                    _pM_ProgressLog = value;
                    if (_pM_ProgressLog != null)
                    {
                        _pM_ProgressLog.CollectionChanged += FixupPM_ProgressLog;
                    }
                    OnNavigationPropertyChanged("PM_ProgressLog");
                }
            }
        }
        private TrackableCollection<PM_ProgressLog> _pM_ProgressLog;
    
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
    
        [DataMember]
        public TrackableCollection<PM_Documents> PM_Documents
        {
            get
            {
                if (_pM_Documents == null)
                {
                    _pM_Documents = new TrackableCollection<PM_Documents>();
                    _pM_Documents.CollectionChanged += FixupPM_Documents;
                }
                return _pM_Documents;
            }
            set
            {
                if (!ReferenceEquals(_pM_Documents, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("当启用 ChangeTracking 时，无法设置 FixupChangeTrackingCollection");
                    }
                    if (_pM_Documents != null)
                    {
                        _pM_Documents.CollectionChanged -= FixupPM_Documents;
                    }
                    _pM_Documents = value;
                    if (_pM_Documents != null)
                    {
                        _pM_Documents.CollectionChanged += FixupPM_Documents;
                    }
                    OnNavigationPropertyChanged("PM_Documents");
                }
            }
        }
        private TrackableCollection<PM_Documents> _pM_Documents;
    
        [DataMember]
        public PM_Attachment PM_Attachment
        {
            get { return _pM_Attachment; }
            set
            {
                if (!ReferenceEquals(_pM_Attachment, value))
                {
                    var previousValue = _pM_Attachment;
                    _pM_Attachment = value;
                    FixupPM_Attachment(previousValue);
                    OnNavigationPropertyChanged("PM_Attachment");
                }
            }
        }
        private PM_Attachment _pM_Attachment;

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
            PM_ProgressLog.Clear();
            PM_Project = null;
            PM_Documents.Clear();
            PM_Attachment = null;
        }

        #endregion

        #region 关联修复
    
        private void FixupPM_Project(PM_Project previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PM_Task.Contains(this))
            {
                previousValue.PM_Task.Remove(this);
            }
    
            if (PM_Project != null)
            {
                if (!PM_Project.PM_Task.Contains(this))
                {
                    PM_Project.PM_Task.Add(this);
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
    
        private void FixupPM_Attachment(PM_Attachment previousValue)
        {
            // 这是执行级联删除的关联中的主体端。
            // 更新事件侦听器以引用新依赖。
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (PM_Attachment != null)
            {
                ChangeTracker.ObjectStateChanging += PM_Attachment.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && ReferenceEquals(previousValue.PM_Task, this))
            {
                previousValue.PM_Task = null;
            }
    
            if (PM_Attachment != null)
            {
                PM_Attachment.PM_Task = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("PM_Attachment")
                    && (ChangeTracker.OriginalValues["PM_Attachment"] == PM_Attachment))
                {
                    ChangeTracker.OriginalValues.Remove("PM_Attachment");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("PM_Attachment", previousValue);
                    // 这是识别关联的主体端，因此在移除关系时必须删除依赖。
                    // 如果依赖的当前状态为“已添加”，则可以更改关系而不会导致删除依赖。
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                    {
                        previousValue.MarkAsDeleted();
                    }
                }
                if (PM_Attachment != null && !PM_Attachment.ChangeTracker.ChangeTrackingEnabled)
                {
                    PM_Attachment.StartTracking();
                }
            }
        }
    
        private void FixupPM_ProgressLog(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (PM_ProgressLog item in e.NewItems)
                {
                    item.PM_Task = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PM_ProgressLog", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PM_ProgressLog item in e.OldItems)
                {
                    if (ReferenceEquals(item.PM_Task, this))
                    {
                        item.PM_Task = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PM_ProgressLog", item);
                    }
                }
            }
        }
    
        private void FixupPM_Documents(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (PM_Documents item in e.NewItems)
                {
                    item.PM_Task = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PM_Documents", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PM_Documents item in e.OldItems)
                {
                    if (ReferenceEquals(item.PM_Task, this))
                    {
                        item.PM_Task = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PM_Documents", item);
                    }
                }
            }
        }

        #endregion

    }
}

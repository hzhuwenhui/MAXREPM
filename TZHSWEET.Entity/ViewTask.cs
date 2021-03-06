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
    public partial class ViewTask: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public string FullName
        {
            get { return _fullName; }
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }
        private string _fullName;

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
        }

        #endregion

    }
}

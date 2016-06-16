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
    [KnownType(typeof(tbModulePermission))]
    public partial class tbModule: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基元属性
    
        [DataMember]
        public int ModuleID
        {
            get { return _moduleID; }
            set
            {
                if (_moduleID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("属性“ModuleID”是对象键的一部分，不可更改。仅当未跟踪对象或对象处于“已添加”状态时，才能对键属性进行更改。");
                    }
                    _moduleID = value;
                    OnPropertyChanged("ModuleID");
                }
            }
        }
        private int _moduleID;
    
        [DataMember]
        public string ModuleName
        {
            get { return _moduleName; }
            set
            {
                if (_moduleName != value)
                {
                    _moduleName = value;
                    OnPropertyChanged("ModuleName");
                }
            }
        }
        private string _moduleName;
    
        [DataMember]
        public string ModuleLinkUrl
        {
            get { return _moduleLinkUrl; }
            set
            {
                if (_moduleLinkUrl != value)
                {
                    _moduleLinkUrl = value;
                    OnPropertyChanged("ModuleLinkUrl");
                }
            }
        }
        private string _moduleLinkUrl;
    
        [DataMember]
        public string ModuleIcon
        {
            get { return _moduleIcon; }
            set
            {
                if (_moduleIcon != value)
                {
                    _moduleIcon = value;
                    OnPropertyChanged("ModuleIcon");
                }
            }
        }
        private string _moduleIcon;
    
        [DataMember]
        public Nullable<int> ParentNo
        {
            get { return _parentNo; }
            set
            {
                if (_parentNo != value)
                {
                    _parentNo = value;
                    OnPropertyChanged("ParentNo");
                }
            }
        }
        private Nullable<int> _parentNo;
    
        [DataMember]
        public Nullable<byte> Sort
        {
            get { return _sort; }
            set
            {
                if (_sort != value)
                {
                    _sort = value;
                    OnPropertyChanged("Sort");
                }
            }
        }
        private Nullable<byte> _sort;
    
        [DataMember]
        public Nullable<bool> IsVisible
        {
            get { return _isVisible; }
            set
            {
                if (_isVisible != value)
                {
                    _isVisible = value;
                    OnPropertyChanged("IsVisible");
                }
            }
        }
        private Nullable<bool> _isVisible;
    
        [DataMember]
        public Nullable<bool> IsLeaf
        {
            get { return _isLeaf; }
            set
            {
                if (_isLeaf != value)
                {
                    _isLeaf = value;
                    OnPropertyChanged("IsLeaf");
                }
            }
        }
        private Nullable<bool> _isLeaf;
    
        [DataMember]
        public Nullable<bool> IsMenu
        {
            get { return _isMenu; }
            set
            {
                if (_isMenu != value)
                {
                    _isMenu = value;
                    OnPropertyChanged("IsMenu");
                }
            }
        }
        private Nullable<bool> _isMenu;
    
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
        public string ModuleController
        {
            get { return _moduleController; }
            set
            {
                if (_moduleController != value)
                {
                    _moduleController = value;
                    OnPropertyChanged("ModuleController");
                }
            }
        }
        private string _moduleController;

        #endregion

        #region 导航属性
    
        [DataMember]
        public TrackableCollection<tbModulePermission> tbModulePermissions
        {
            get
            {
                if (_tbModulePermissions == null)
                {
                    _tbModulePermissions = new TrackableCollection<tbModulePermission>();
                    _tbModulePermissions.CollectionChanged += FixuptbModulePermissions;
                }
                return _tbModulePermissions;
            }
            set
            {
                if (!ReferenceEquals(_tbModulePermissions, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("当启用 ChangeTracking 时，无法设置 FixupChangeTrackingCollection");
                    }
                    if (_tbModulePermissions != null)
                    {
                        _tbModulePermissions.CollectionChanged -= FixuptbModulePermissions;
                    }
                    _tbModulePermissions = value;
                    if (_tbModulePermissions != null)
                    {
                        _tbModulePermissions.CollectionChanged += FixuptbModulePermissions;
                    }
                    OnNavigationPropertyChanged("tbModulePermissions");
                }
            }
        }
        private TrackableCollection<tbModulePermission> _tbModulePermissions;

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
            tbModulePermissions.Clear();
        }

        #endregion

        #region 关联修复
    
        private void FixuptbModulePermissions(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (tbModulePermission item in e.NewItems)
                {
                    item.tbModule = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("tbModulePermissions", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (tbModulePermission item in e.OldItems)
                {
                    if (ReferenceEquals(item.tbModule, this))
                    {
                        item.tbModule = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("tbModulePermissions", item);
                    }
                }
            }
        }

        #endregion

    }
}

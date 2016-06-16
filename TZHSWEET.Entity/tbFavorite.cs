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
    [KnownType(typeof(tbUser))]
    public partial class tbFavorite: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region 基元属性
    
        [DataMember]
        public int FavoriteID
        {
            get { return _favoriteID; }
            set
            {
                if (_favoriteID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("属性“FavoriteID”是对象键的一部分，不可更改。仅当未跟踪对象或对象处于“已添加”状态时，才能对键属性进行更改。");
                    }
                    _favoriteID = value;
                    OnPropertyChanged("FavoriteID");
                }
            }
        }
        private int _favoriteID;
    
        [DataMember]
        public string FavoriteTitle
        {
            get { return _favoriteTitle; }
            set
            {
                if (_favoriteTitle != value)
                {
                    _favoriteTitle = value;
                    OnPropertyChanged("FavoriteTitle");
                }
            }
        }
        private string _favoriteTitle;
    
        [DataMember]
        public Nullable<System.DateTime> FavoriteAddTime
        {
            get { return _favoriteAddTime; }
            set
            {
                if (_favoriteAddTime != value)
                {
                    _favoriteAddTime = value;
                    OnPropertyChanged("FavoriteAddTime");
                }
            }
        }
        private Nullable<System.DateTime> _favoriteAddTime;
    
        [DataMember]
        public string FavoriteContent
        {
            get { return _favoriteContent; }
            set
            {
                if (_favoriteContent != value)
                {
                    _favoriteContent = value;
                    OnPropertyChanged("FavoriteContent");
                }
            }
        }
        private string _favoriteContent;
    
        [DataMember]
        public Nullable<int> UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    ChangeTracker.RecordOriginalValue("UserID", _userID);
                    if (!IsDeserializing)
                    {
                        if (tbUser != null && tbUser.UserID != value)
                        {
                            tbUser = null;
                        }
                    }
                    _userID = value;
                    OnPropertyChanged("UserID");
                }
            }
        }
        private Nullable<int> _userID;
    
        [DataMember]
        public string Url
        {
            get { return _url; }
            set
            {
                if (_url != value)
                {
                    _url = value;
                    OnPropertyChanged("Url");
                }
            }
        }
        private string _url;
    
        [DataMember]
        public string Icon
        {
            get { return _icon; }
            set
            {
                if (_icon != value)
                {
                    _icon = value;
                    OnPropertyChanged("Icon");
                }
            }
        }
        private string _icon;

        #endregion

        #region 导航属性
    
        [DataMember]
        public tbUser tbUser
        {
            get { return _tbUser; }
            set
            {
                if (!ReferenceEquals(_tbUser, value))
                {
                    var previousValue = _tbUser;
                    _tbUser = value;
                    FixuptbUser(previousValue);
                    OnNavigationPropertyChanged("tbUser");
                }
            }
        }
        private tbUser _tbUser;

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
            tbUser = null;
        }

        #endregion

        #region 关联修复
    
        private void FixuptbUser(tbUser previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.tbFavorites.Contains(this))
            {
                previousValue.tbFavorites.Remove(this);
            }
    
            if (tbUser != null)
            {
                if (!tbUser.tbFavorites.Contains(this))
                {
                    tbUser.tbFavorites.Add(this);
                }
    
                UserID = tbUser.UserID;
            }
            else if (!skipKeys)
            {
                UserID = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("tbUser")
                    && (ChangeTracker.OriginalValues["tbUser"] == tbUser))
                {
                    ChangeTracker.OriginalValues.Remove("tbUser");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("tbUser", previousValue);
                }
                if (tbUser != null && !tbUser.ChangeTracker.ChangeTrackingEnabled)
                {
                    tbUser.StartTracking();
                }
            }
        }

        #endregion

    }
}

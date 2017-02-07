using DealershipManagementApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipManagementApplication.ViewModels
{

    public class BaseViewModel
    {
        public BaseViewModel()
        {

        }

        private int _State;
        public int State
        {
            get { return _State; }
        }

        private int _PrimaryKey;
        private int PrimaryKey
        {
            set { _PrimaryKey = value; }
        }

        private BaseModel _StateModel;
        public BaseModel Model
        {
            get { return _StateModel; }
            set { _StateModel = value; }
        }

        public virtual void Initialize()
        {
            LoadCommonCollection();
        }

        public virtual void LoadCommonCollection()
        {
            CommonCollection = new Dictionary<string, List<BaseModel>>();
        }

        public void ChangeState(int state = 0)
        {
            Initialize();
            _State = state;
            DoStateChange(state);
        }

        public int GetPrimaryKey()
        {
            return _PrimaryKey;
        }

        public void SetPrimaryKey(int primaryKey)
        {
            _PrimaryKey = primaryKey;
        }

        private void DoStateChange(int state)
        {
            if (state == 0)
                InitiateDefaultState();
            else if (state == 1)
                InitiateSelectedState();
        }

        protected virtual void InitiateDefaultState()
        {

        }

        protected virtual void InitiateSelectedState()
        {

        }

        protected List<T> GetData<T>(string keyName)
        {
            if (object.ReferenceEquals(CommonCollection, null))
            {
                var obj = CommonCollection[keyName];
                return obj.Cast<T>().ToList();
            }
            return new List<T>();
        }

        protected virtual void CreateModel<T>() where T : BaseModel
        {

        }

        protected virtual void SelectModel()
        {

        }

        protected List<BaseModel> GetListData<T>(List<T> baseList) where T : BaseModel
        {
            return baseList.Cast<BaseModel>().ToList();
        }

        public Dictionary<string, List<BaseModel>> CommonCollection { get; set; }


    }
}

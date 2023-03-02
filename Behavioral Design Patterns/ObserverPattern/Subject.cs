using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 被观察者
    /// </summary>
    public abstract class Subject
    {
        /// <summary>
        /// 被观察者的状态
        /// </summary>
        private int State;
        //观察者列表
        private List<Observer> observers=new List<Observer>();

        /// <summary>
        /// 获取状态
        /// </summary>
        /// <returns></returns>
        public int GetState()
        {
            return State;
        }

        /// <summary>
        /// 设置状态
        /// </summary>
        /// <param name="state"></param>
        public void SetState(int state)
        {
            State = state;
            NotifyObserver();
        }

        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void DelObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void NotifyObserver()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}

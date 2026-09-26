using Matrimony.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace Matrimony.Services
{
    public class DatabaseService
    {
        SQLiteConnection SQLiteConnection;
        public DatabaseService()
        {
            SQLiteConnection = DependencyService.Get<IDatabaseService>().GetSQLiteConnection();
            SQLiteConnection.CreateTable<Member>();
            SQLiteConnection.CreateTable<AppMember>();
        }
        public void SaveOrUpdateAppMember(AppMember member)
        {
            var appMember = SQLiteConnection.Table<AppMember>().ToList().FirstOrDefault();
            if (appMember != null && member.appMemberId== appMember.appMemberId)
            {
                try
                {
                    SQLiteConnection.Update(member);
                }
                catch(Exception ex)
                {

                }
                
            }
            else
            {
                SQLiteConnection.Insert(member);
            }
        }
        public AppMember GetAppMember()
        {
            return SQLiteConnection.Table<AppMember>().ToList().FirstOrDefault();
        }
        public AppMember GetAppMemberById(int appMemberId)
        {
            AppMember member = GetAllAppMembers().Where(x => x.appMemberId == appMemberId).FirstOrDefault();
            return member;
        }
        public void SaveOrUpdate(Member member)
        {
            var membersaved = GetAllMembers().Where(x => x.MemberId == member.MemberId).FirstOrDefault();
            if (membersaved != null)
            {
                SQLiteConnection.Update(member);
            }
            else
            {
                SQLiteConnection.Insert(member);
            }
        }

        public List<Member> GetAllMembers()
        {
            return SQLiteConnection.Table<Member>().ToList();
        }
        public List<AppMember> GetAllAppMembers()
        {
            return SQLiteConnection.Table<AppMember>().ToList();
        }
    }
}

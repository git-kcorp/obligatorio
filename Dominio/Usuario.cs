using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Usuario
    {
        private static int _nextId = 1;

        private int _id;
        private string _mail;
        private string _password;
        private string _usuario;

        public int Id { get { return _id; } }
        public string Mail { get { return _mail; } set { _mail = value; } }
        public string User { get { return _usuario; } set { _usuario = value; } }
        public string Password { get { return _password; } set { _password = value; } }

        public Usuario(string mail,string user,string password)
        {
            this._id = _nextId++;
            this._mail = mail;
            this._usuario = user;
            this._password = password;
        }
        public Usuario() { }

        private string getUser()
        {
            return this._usuario;
        }
        public string GetUser()
        {
            return getUser();
        }

        private string getPassword()
        {
            return this._password;
        }

        public string GetPassword()
        {
            return getPassword();
        }

        private string getMail()
        {
            return this._mail;
        }
        public string GetMail()
        {
            return getMail();
        }
        public int getId()
        {
            return this._id;
        }
        public int GetId()
        {
            return getId();
        }
        private void changeMail(string mail)
        {
            this._mail = mail;

        }
        public void ChangeMail(string mail)
        {
            changeMail(mail);
        }
    }
}

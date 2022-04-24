using System.Collections.Generic;
using System.ComponentModel;
using Supabase;
using Supabase.Realtime;
using Client = Supabase.Client;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

namespace lab4
{
    internal class Database : INotifyPropertyChanged
    {
        public IEnumerable<Messages> Messages { get; set; }
        public IEnumerable<Users> Users { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        private Client Client { get; }
        public Database()
        {
            string url = "https://mzyocifeecmwedxmhlhf.supabase.co";
            string key = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6Im16eW9jaWZlZWNtd2VkeG1obGhmIiwicm9sZSI6ImFub24iLCJpYXQiOjE2NDYyMzA4MTAsImV4cCI6MTk2MTgwNjgxMH0.lxq8orgzqboWm_mcmf7tJySZyRNkPlHBpHLl2IDGB64";
            
            Messages = new List<Messages>();
            Users = new List<Users>();

            Client.InitializeAsync(url, key, new SupabaseOptions { AutoConnectRealtime = true, ShouldInitializeRealtime = true });
            Client = Client.Instance;

            Client.From<Messages>().On(Client.ChannelEventType.All, MessagesChanged);
            Client.From<Users>().On(Client.ChannelEventType.All, UsersChanged);

            LoadUsers();
            LoadMessages();
        }
        private void MessagesChanged(object sender, SocketResponseEventArgs e)
        {
            LoadMessages();
        }
        public async void LoadMessages()
        {
            var data = await Client.From<Messages>().Get();
            Messages = data.Models;
            OnPropertyChanged(nameof(Messages));
        }
        private void UsersChanged(object sender, SocketResponseEventArgs e)
        {
            LoadUsers();
        }
        public async void LoadUsers()
        {
            var data = await Client.From<Users>().Get();
            Users = data.Models;
            OnPropertyChanged(nameof(Users));
        }

        public async void InsertUser(Users user)
        {
            await Client.From<Users>().Insert(user);
        }
        public async void InsertMessage(Messages messages)
        {
            await Client.From<Messages>().Insert(messages);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

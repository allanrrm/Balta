using System;
using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notifiable
    {


        public Base()
        {
            Id = Guid.NewGuid();     //Ponto Unico de Falha SPOF
        }

        public Guid Id { get; set; }
    }
}
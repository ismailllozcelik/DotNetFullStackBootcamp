using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Odevleri
{
    //   Senaryo 2: Oyun Geliştirme
    // Açıklama:
    // Bir oyun geliştirme projesinde, oyun içerisindeki karakterlerin belirli 
    // olaylara tepki vermesi gerekmektedir.Örneğin, bir karakterin canı belirli bir
    // seviyenin altına düştüğünde veya bir düşman öldüğünde bu olaylara tepki vermek için event ve delegate kullanılabilir.


    // Delegate tanımlanması
    public delegate void CharacterEventHandler(string message);

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        // Event tanımlanması
        public event CharacterEventHandler HealthChanged;
        public event CharacterEventHandler Died;

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                // Can 0 veya daha az ise Died event'i tetiklenir
                Died?.Invoke($"{Name} died.");
            }
            else
            {
                // Can değişikliği olduğunda HealthChanged event'i tetiklenir
                HealthChanged?.Invoke($"{Name} health changed. Health: {Health}");
            }
        }
    }

    public class Game
    {
        public void StartGame()
        {
            Character character = new Character { Name = "Player1", Health = 100 };
            character.HealthChanged += OnHealthChanged;
            character.Died += OnDied;

            character.TakeDamage(20);
            character.TakeDamage(50);
            character.TakeDamage(50);
        }

        public void OnHealthChanged(string message)
        {
            Console.WriteLine($"Health Changed: {message}");
        }

        public void OnDied(string message)
        {
            Console.WriteLine($"Died: {message}");
        }
    }
}

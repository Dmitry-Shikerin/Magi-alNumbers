using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Магические_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Weapon
    {
        private const int _minValueBullets = 0;
        private const int _bulletsPerShot = 1;

        private int _bullets;

        public bool CanShoot() => _bullets > _minValueBullets;

        public void Shoot() => _bullets -= _bulletsPerShot;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponDamage
{
    abstract class WeaponDamage
    {
        /// <summary>
        /// 생성자는 기본 Magic, Flaming 값과 주사위 3개를 굴려서 나온 값을 기준으로 데미지를 계산합니다.
        /// </summary>
        /// <param name="startingRoll">주사위 3개를 굴려서 나온 값</param>
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }
        public Random random = new();
        /// <summary>
        /// 계산된 데미지 값을 저장합니다.
        /// </summary>
        public int Damage { get; protected set; }

        private int roll;
        /// <summary>
        /// 주사위 3개를 굴려서 나온 값을 설정하거나 반환합니다.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                if (value > 0)
                    roll = value;
                CalculateDamage();
            }
        }

        private bool flaming;
        /// <summary>
        /// 불타는 칼이면 true, 아니면 false를 반환합니다.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        private bool magic;
        /// <summary>
        /// 마법 칼이면 true, 아니면 false를 반환합니다.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        protected abstract void CalculateDamage();
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    [CreateAssetMenu(menuName = "GameConfig", fileName = "GameConfig")]
    public class Config : ScriptableObject
    {
        #region codes
        public static Config current;


        private void OnDisable()
        {
            if (ReferenceEquals(current, this))
            {
                current = null;
            }
        }
        #endregion


        [Range(1, 256)]
        public int pixelPerUnit = 100;

        public float scaled_pixel_per_unit { get; set; } = 100;

        public Vector2Int desiredResolution = new Vector2Int(1920, 1080);

        public float desiredPerspectiveFOV = 60;


        #region const
        //帧率
        public const int PHYSICS_TICKS_PER_SECOND = 60;
        public const float PHYSICS_TICK_DELTA_TIME = 1f / PHYSICS_TICKS_PER_SECOND;
        #endregion


        #region BLL
        public float pos_coef = 1.875f;
        #endregion
    }

}

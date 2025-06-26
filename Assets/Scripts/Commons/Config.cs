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

        [Header("主界面")] public string main_menu_website_weibo = "https://weibo.com/u/1002143827";
        [Header("主界面")] public string main_menu_website_bilibili = "https://space.bilibili.com/423895";
        [Header("主界面")] public string main_menu_website_bug_report;

        [Header("YH 存档")]
        public string save_00_path = @"D:\save_00.dat";

        [Header("车体运动 - 车身旋转")] public float caravan_rotate_angle_limit = 60f;  // FT沿用
        [Header("车体运动 - 车身旋转")] public float caravan_rotation_damp_1 = 60f; // FT沿用
        [Header("车体运动 - 车身旋转")] public float caravan_rotation_damp_2 = 6f; // FT沿用

        [Header("YH 车体运动")] public float gravity = -10f;
        [Header("YH 车体运动")] public float acc_braking = -30f;
        [Header("YH 车体运动")] public float caravan_bounce_coefficient = 0.6f;
        [Header("YH 车体运动")] public float caravan_bounce_loss = 500f;

        [Header("主菜单界面 - 测试关卡入口")] public Vector2Int test_level_body_id;
        [Header("主菜单界面 - 测试关卡入口")] public uint test_level_world_id;
        [Header("主菜单界面 - 测试关卡入口")] public uint test_level_level_id;
        [Header("主菜单界面 - 测试关卡入口")] public bool show_test_level;

        [Header("场景切换/场景名UI")]
        public float scene_title_fade_out_time;
        [Header("场景切换/场景名UI")]
        public float scene_title_lasting_time;

        [Header("YH Game Init 初始化")] public string first_load_scene = "InitScene"; //首次加载scene
        [Header("YH Game Init 初始化")] public uint caravan_id = 100000000u;
        [Header("YH Game Init 初始化")] public uint init_wheel = 1210101u;
        [Header("YH Game Init 初始化")] public uint init_device_in_slot_top;
        [Header("YH Game Init 初始化")] public uint init_device_in_slot_front_top;
        [Header("YH Game Init 初始化")] public uint init_device_in_slot_back_top;
        [Header("YH Game Init 初始化")] public uint init_device_in_slot_front;
        [Header("YH Game Init 初始化")] public uint init_device_in_slot_back;
        [Header("YH Game Init 初始化")] public List<int> init_roles;

        [Header("YH Backpack 背包")] public float per_overweight_slot_weight = 300;
        [Header("YH Backpack 背包")] public int basic_backpack_slot_num = 5;

        [Serializable]
        public class InitBackPack
        {
            public int item_id;
            public int item_count;
        }

        [Header("YH Backpack 背包")]
        public List<InitBackPack> init_backpack_items = new List<InitBackPack>();

        [Header("YH Camera 镜头运动")] public float travel_scene_camera_offset_x;  // FT沿用
        [Header("YH Camera 镜头运动")] public float cam_pos_offset_y;
        [Header("YH Camera 镜头运动")] public float cam_pos_offset_z;
        [Header("YH Camera 镜头运动")] public bool free_camera;

        [Header("YH Encounter 奇遇事件")] public float trigger_length = 25;
        [Header("YH Encounter 奇遇事件")] public float notice_length_1 = 50f;
        [Header("YH Encounter 奇遇事件")] public float notice_length_2 = 10f;
        [Header("YH Encounter 奇遇事件")] public float event_btn_car_vx_limit = 0.1f;
        [Header("YH Encounter 奇遇事件")] public int event_btn_car_parking_ticks = 60;

        [Header("YH Hookrope 钩索")] public float rope_max_length;
        [Header("YH Hookrope 钩索")] public float rope_min_length;
        [Header("YH Hookrope 钩索")] public float rope_elasticity;

        [Header("YH Loot 掉落物")] public float loot_pickup_distance = 0.1f;
        [Header("YH Loot 掉落物")] public float loot_attraction_power = 20f;
        [Header("YH Loot 掉落物")] public float coin_surface_bounce_coef = 1f;
        [Header("YH Loot 掉落物")] public float caravan_vel2_screen_bounce = 0.5f;

        [Header("YH Monster 怪物")] public float monster_grip = 35f;
        [Header("YH Monster 怪物")] public float fling_off_dis = 40f;

        [Header("YH Monster_Tide 兽潮")] public int time_pressure_min = 15;
        [Header("YH Monster_Tide 兽潮")] public int time_pressure_max = 60;
        [Header("YH Monster_Tide 兽潮")] public int pressure_kill_score = 40;

        [Header("YH Power_Lever 动力拉杆")] public float lever_up_speed = 1.2f;
        [Header("YH Power_Lever 动力拉杆")] public float lever_down_speed = -0.8f;
        [Header("YH Power_Lever 动力拉杆")] public float lever_move_delta = 0.01f;

        [Header("YH Projectile 飞射物")] public float bullet_bounce_threshold_ekmin = 100f;
        [Header("YH Projectile 飞射物")] public float bullet_surface_bounce_coef = 0.5f;
        [Header("YH Projectile 飞射物")] public float bullet_bounce_threshold_vmax = 20f;
        [Header("YH Projectile 飞射物")] public float surface_friction = 0.3f;
        [Header("YH Projectile 飞射物")] public float arrow_penetration_loss = 10f;
        [Header("YH Projectile 飞射物")] public float bullet_penetration_loss = 6f;
        [Header("YH Projectile 飞射物")] public float bullet_enemy_bounce_coef = 0.2f;

        [Header("YH Repair 维修")] public int repairing_counts = 3;
        [Header("YH Repair 维修")] public int repairing_cd_ticks = 720;
        [Header("YH Repair 维修")] public float fix_device_job_effect = 0.03f;
        [Header("YH Repair 维修")] public float fix_caravan_job_effect = 0.01f;

        [Header("YH SFX 音效")] public string SE_target_locked;
        [Header("YH SFX 音效")] public string SE_fix;
        [Header("YH SFX 音效")] public string SE_fix_fail;
        [Header("YH SFX 音效")] public string SE_monster_die;
        [Header("YH SFX 音效")] public string SE_encounter_radar;   //接近奇遇时的雷达提示声
        [Header("YH SFX 音效")] public string SE_pick_up_item;   //拾取物品的提示声

        [Header("YH VFX_Device_Damaged 设备损毁特效")] public string devicedestroy_vfx;
        [Header("YH VFX_Device_Damaged 设备损毁特效")] public string devicesmoke_vfx;

        [Header("YH Work 工作")] public int normal_work_ability;

        [Header("YH测试")] public bool is_load_devices = true;
        [Header("YH测试")] public bool is_load_enemys = true;
        [Header("YH测试")] public uint test_level_id = 4001;

        [Header("YH安全区")] public float security_zone_distance;
        [Header("YH安全区")] public uint food_id_1;
        [Header("YH安全区")] public uint food_id_2;
        [Header("YH安全区")] public uint food_id_3;
        [Header("YH安全区")] public uint food_id_4;
        [Header("YH安全区")] public uint coin_id;

        [Header("YH大本营")] public Vector2 camp_camera_size_range = new(3f, 25f);
        [Header("YH大本营")] public float camp_camera_zoom_speed = 0.2f;

        #region const
        //帧率
        public const int PHYSICS_TICKS_PER_SECOND = 120;
        public const float PHYSICS_TICK_DELTA_TIME = 1f / PHYSICS_TICKS_PER_SECOND;
        #endregion

        #region internal_setting
        //Mgr tick优先级
        public const int CaravanMgr_Priority = 1;
        public const int DeviceMgr_Priority = 2;
        public const int EnemyMgr_Priority = 3;
        public const int New_EnemyMgr_Priority = 3;
        public const int EnvironmentMgr_Priority = 4;
        public const int MapMgr_Priority = 5;
        public const int CardMgr_Priority = 6;
        public const int ProjectileMgr_Priority = 7;
        public const int ProjectileMgr_Enemy_Priority = 8;
        public const int SisterMgr_Priority = 9;
        public const int BrotherMgr_Priority = 10;
        public const int Base_SlotMgr_Priority = 11;
        public const int Vfx_Priority = 99;

        public const int BuffMgr_Priority = 0;

        public const int CoreMgr_Priority = 20;

        //Mgr注册name(tick)
        public const string PlayerMgr_Name = "Player";
        public const string AdventureMgr_Name = "Adventure";
        public const string ProjectileMgr_Name = "ProjectileMgr";
        public const string GarageMgr_Name = "GarageMgr";
        public const string CaravanMgr_Name = "CaravanMgr";
        public const string DeviceMgr_Name = "DeviceMgr";
        public const string CoreMgr_Name = "CoreMgr";
        public const string EnemyMgr_Name = "EnemyMgr";
        public const string New_EnemyMgr_Name = "New_EnemyMgr";
        public const string BuffMgr_Name = "BuffMgr";
        public const string WorkMgr_Name = "WorkMgr";
        public const string CharacterMgr_Name = "CharacterMgr";
        public const string RelicMgr_Name = "RelicMgr";

        public const string EnvironmentMgr_Name = "enviroment";
        public const string CardMgr_Name = "CardMgr";
        public const string WareHouseMgr_Name = "WareHouse";
        public const string MapMgr_Name = "MapMgr";
        public const string ProjectileMgr_Enemy_Name = "ProjectileMgr_Enemy";
        public const string SisterMgr_Name = "SisterMgr";
        public const string BrotherMgr_Name = "BrotherMgr";
        public const string BgmMgr_Name = "BgmMgr";
        public const string HoldingDeviceMgr_Name = "HoldingDeviceMgr";
        public const string Vfx_Name = "Vfx";

        //Mgr注册name(普通)
        public const string RewardHouse_Name = "RewardHouse";
        public const string Elite_Battle_TimerMgr_Name = "Elite_Battle_TimerMgr";
        public const string SelectLevelMgr_Name = "SelectLevel";

        #endregion
    }

}

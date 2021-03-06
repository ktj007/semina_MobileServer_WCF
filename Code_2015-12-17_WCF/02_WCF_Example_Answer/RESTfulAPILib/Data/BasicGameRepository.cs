﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulAPILib.Data
{
    // 유저의 기본 게임 데이터 저장
    public static class BasicGameRepository
    {
        static List<BasicGameData> GameDatas = new List<BasicGameData>();

        // 기본 게임 데이터 저장
        public static void AddGameData(string id)
        {
            var rand = new Random();

            var gameData = new BasicGameData()
            {
                ID = id,
                Level = rand.Next(1, 11),
                Money = rand.Next(1000, 100000),
            };

            GameDatas.Add(gameData);
        }

        // 기본 게임 데이터 불러오기
        public static BasicGameData GetGameData(string id)
        {
            return GameDatas.Find(data => data.ID == id);
        }
    }

    // 기본 게임 데이터
    public class BasicGameData
    {
        public string ID;
        public int Level;
        public Int64 Money;
    }
}

﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT_Model
{
    public class UtPlayer
    {
        [Fact]
        public void TestConstructor()
        {
            Player player = new Player(1, "Jordan", "Artzet", "Firologia","avatar.png");
            Assert.NotNull(player);
            Assert.Equal(1,player.Id);
            Assert.Equal("Jordan", player.FirstName);
            Assert.Equal("Artzet", player.LastName);
            Assert.Equal("Firologia", player.NickName);
            Assert.Equal("avatar.png", player.Avatar);

        }
    }
}

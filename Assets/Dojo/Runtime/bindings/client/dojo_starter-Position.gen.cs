// Generated by dojo-bindgen on Thu, 26 Sep 2024 03:06:36 +0000. Do not modify this file manually.
using System;
using Dojo;
using Dojo.Starknet;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Enum = Dojo.Starknet.Enum;

// Type definition for `dojo_starter::models::Vec2` struct
[Serializable]
public struct Vec2 {
    public uint x;
    public uint y;
}


namespace dojo_starter {
    // Model definition for `dojo_starter::models::Position` model
    public class Position : ModelInstance {
        [ModelField("player")]
        public FieldElement player;

        [ModelField("vec")]
        public Vec2 vec;

        // Start is called before the first frame update
        void Start() {
        }
    
        // Update is called once per frame
        void Update() {
        }
    }
}

        
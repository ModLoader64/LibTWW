//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_player_config_c  {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u8 mRuby {get => this._mRuby(); set => this._mRuby(value);}//;
        
        public u8 mSoundMode {get => this._mSoundMode(); set => this._mSoundMode(value);}//;
        
        public u8 mAttentionType {get => this._mAttentionType(); set => this._mAttentionType(value);}//;
        
        public u8 mVibration {get => this._mVibration(); set => this._mVibration(value);}//;
        
        public u8 field_0x4 {get => this._field_0x4(); set => this._field_0x4(value);}//;
        
        public dSv_player_config_c (u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x5;
        }
        
        private u8 _mRuby() {
            return Memory.RAM.ReadU8(this.pointer + 0x0);
        }
        
        private void _mRuby(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x0, value);
        }
        
        private u8 _mSoundMode() {
            return Memory.RAM.ReadU8(this.pointer + 0x1);
        }
        
        private void _mSoundMode(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x1, value);
        }
        
        private u8 _mAttentionType() {
            return Memory.RAM.ReadU8(this.pointer + 0x2);
        }
        
        private void _mAttentionType(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x2, value);
        }
        
        private u8 _mVibration() {
            return Memory.RAM.ReadU8(this.pointer + 0x3);
        }
        
        private void _mVibration(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x3, value);
        }
        
        private u8 _field_0x4() {
            return Memory.RAM.ReadU8(this.pointer + 0x4);
        }
        
        private void _field_0x4(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x4, value);
        }
    }
}
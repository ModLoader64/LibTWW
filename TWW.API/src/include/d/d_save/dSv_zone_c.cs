//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dSv_zone_c {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public s8 mRoomNo {get => this._mRoomNo(); set => this._mRoomNo(value);}//;
        
        public dSv_zoneBit_c mZoneBit {get => this._mZoneBit(); set => this._mZoneBit(value);}//;
        
        public dSv_zoneActor_c mZoneActor {get => this._mZoneActor(); set => this._mZoneActor(value);}//;
        
        public dSv_zone_c(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x4C;
        }
        
        private s8 _mRoomNo() {
            return Memory.RAM.ReadS8(this.pointer + 0x00);
        }
        
        private void _mRoomNo(s8 value) {
            Memory.RAM.WriteS8(this.pointer + 0x00, value);
        }
        
        private dSv_zoneBit_c _mZoneBit() {
            return new dSv_zoneBit_c(this.pointer + 0x02);
        }
        
        private void _mZoneBit(dSv_zoneBit_c value) {
        }
        
        private dSv_zoneActor_c _mZoneActor() {
            return new dSv_zoneActor_c(this.pointer + 0x0C);
        }
        
        private void _mZoneActor(dSv_zoneActor_c value) {
        }
    }
}

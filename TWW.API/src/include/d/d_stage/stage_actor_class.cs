//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class stage_actor_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public u32 num {get => this._num(); set => this._num(value);}//;
        
        public stage_actor_data_class m_entries {get => this._m_entries(); set => this._m_entries(value);}//;
        
        public stage_actor_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private u32 _num() {
            return Memory.RAM.ReadU32(this.pointer + 0x0);
        }
        
        private void _num(u32 value) {
            Memory.RAM.WriteU32(this.pointer + 0x0, value);
        }
        
        private stage_actor_data_class _m_entries() {
            return new stage_actor_data_class(this.pointer + 0x4);
        }
        
        private void _m_entries(stage_actor_data_class value) {
        }
    }
}

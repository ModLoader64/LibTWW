//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class overlap_process_profile_definition {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public leaf_process_profile_definition base {get => this._base(); set => this._base(value);}//;
        
        public overlap_method_class mSubMtd {get => this._mSubMtd(); set => this._mSubMtd(value);}//;
        
        public overlap_process_profile_definition(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x28;
        }
        
/*        private leaf_process_profile_definition _base() {
            return new leaf_process_profile_definition(this.pointer + 0x00);
        }
        
        private void _base(leaf_process_profile_definition value) {
        }*/
        
        private overlap_method_class _mSubMtd() {
            return new overlap_method_class(this.pointer + 0x24);
        }
        
        private void _mSubMtd(overlap_method_class value) {
        }
    }
}

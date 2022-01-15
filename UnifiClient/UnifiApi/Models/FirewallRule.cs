using Newtonsoft.Json;

namespace UnifiApi.Models
{
    public class FirewallRule
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }
        public string ruleset { get; set; }
        public int rule_index { get; set; }
        public string name { get; set; }
        public bool enabled { get; set; }
        public string action { get; set; }
        public bool protocol_match_excepted { get; set; }
        public bool logging { get; set; }
        public bool state_new { get; set; }
        public bool state_established { get; set; }
        public bool state_invalid { get; set; }
        public bool state_related { get; set; }
        public string ipsec { get; set; }
        public string[] src_firewallgroup_ids { get; set; }
        public string src_mac_address { get; set; }
        public string[] dst_firewallgroup_ids { get; set; }
        public string dst_address { get; set; }
        public string src_address { get; set; }
        public string protocol { get; set; }
        public string icmp_typename { get; set; }
        public string src_networkconf_id { get; set; }
        public string src_networkconf_type { get; set; }
        public string dst_networkconf_id { get; set; }
        public string dst_networkconf_type { get; set; }
        public string site_id { get; set; }
    }
}

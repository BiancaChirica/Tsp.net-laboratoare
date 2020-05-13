

namespace WebAppL9.Models
{
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class CommentDTO
    {
        [DataMember]
        public int CommentId { get; set; }

        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public int PostPostId { get; set; }

        [DataMember]
        public virtual PostDTO Post { get; set; }
    }
}

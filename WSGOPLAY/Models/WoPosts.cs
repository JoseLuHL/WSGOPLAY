using System;
using System.Collections.Generic;

namespace WSGOPLAY.Models
{
    public partial class WoPosts
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public int RecipientId { get; set; }
        public string PostText { get; set; }
        public int PageId { get; set; }
        public int GroupId { get; set; }
        public int EventId { get; set; }
        public int PageEventId { get; set; }
        public string PostLink { get; set; }
        public string PostLinkTitle { get; set; }
        public string PostLinkImage { get; set; }
        public string PostLinkContent { get; set; }
        public string PostVimeo { get; set; }
        public string PostDailymotion { get; set; }
        public string PostFacebook { get; set; }
        public string PostFile { get; set; }
        public string PostFileName { get; set; }
        public string PostFileThumb { get; set; }
        public string PostYoutube { get; set; }
        public string PostVine { get; set; }
        public string PostSoundCloud { get; set; }
        public string PostPlaytube { get; set; }
        public string PostMap { get; set; }
        public int PostShare { get; set; }
        public string PostPrivacy { get; set; }
        public string PostType { get; set; }
        public string PostFeeling { get; set; }
        public string PostListening { get; set; }
        public string PostTraveling { get; set; }
        public string PostWatching { get; set; }
        public string PostPlaying { get; set; }
        public string PostPhoto { get; set; }
        public int Time { get; set; }
        public string Registered { get; set; }
        public string AlbumName { get; set; }
        public string MultiImage { get; set; }
        public int Boosted { get; set; }
        public int ProductId { get; set; }
        public int PollId { get; set; }
        public int BlogId { get; set; }
        public int VideoViews { get; set; }
        public string PostRecord { get; set; }
        public string PostSticker { get; set; }
        public int SharedFrom { get; set; }
        public string PostUrl { get; set; }
        public int ParentId { get; set; }
        public int Cache { get; set; }
        public int CommentsStatus { get; set; }
        public int Blur { get; set; }
    }
}

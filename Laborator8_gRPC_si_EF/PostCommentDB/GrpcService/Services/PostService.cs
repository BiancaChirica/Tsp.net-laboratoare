using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PostCommentDB;

namespace GrpcService
{
    public class PostService : PostG.PostGBase
    {
        private readonly ILogger<PostService> _logger;
        public PostService(ILogger<PostService> logger)
        {
            _logger = logger;
        }

        public override async Task<PostsList> GetAllPosts(EmptyMsg request, ServerCallContext context)
        {
            Post post = new Post();
            List<Post> postList = post.GetAllPosts();
            PostsList result = new PostsList();
            foreach (Post p in postList)
            {
                
                CommentsList cl = new CommentsList();

                PostModel pm = new PostModel
                {
                    PostId = p.PostId,
                    Description = p.Description,
                    Domain = p.Domain,
                    Date = p.Date.ToString(),
                    Comments = cl
                };

                foreach (Comment com in p.Comments)
                {
                    cl.Coments.Add(new CommentModel {
                        CommentId = com.CommentId,
                        Text = com.Text,
                        PostPostId = com.PostPostId,
                        Post = pm
                    });
                }    

                result.Posts.Add(pm);
            }

            return await Task.FromResult(result);
        }
    }
}

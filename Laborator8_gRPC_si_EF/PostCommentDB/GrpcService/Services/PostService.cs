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
                    cl.Coments.Add(new CommentModel
                    {
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

        public override async Task<PostReplayBool> AddPost(PostModel request, ServerCallContext context)
        {
            DateTime oDate = Convert.ToDateTime(request.Date);

            Post post = new Post
            {
                PostId = 0,
                Description = request.Description,
                Domain = request.Domain,
                Date = oDate,
            };

            foreach (CommentModel cm in request.Comments.Coments)
            {
                Comment newCom = new Comment
                {
                    CommentId = cm.CommentId,
                    Text = cm.Text,
                    PostPostId = cm.PostPostId,
                    Post = post
                };
                post.Comments.Add(newCom);
            }
            return await Task.FromResult(new PostReplayBool { Result = post.AddPost() });
        }

        public override async Task<PostModel> UpdatePost(PostModel request, ServerCallContext context)
        {
            DateTime oDate = Convert.ToDateTime(request.Date);

            Post post = new Post
            {
                PostId = 0,
                Description = request.Description,
                Domain = request.Domain,
                Date = oDate,
            };

            foreach (CommentModel cm in request.Comments.Coments)
            {
                Comment newCom = new Comment
                {
                    CommentId = cm.CommentId,
                    Text = cm.Text,
                    PostPostId = cm.PostPostId,
                    Post = post
                };
                post.Comments.Add(newCom);
            }

             post = post.UpdatePost(post);

            PostModel postModel = new PostModel
            {
                PostId = post.PostId,
                Description = post.Description,
                Domain = post.Domain,
                Date = post.Date.ToString()
            };


            foreach (Comment com in post.Comments)
            {
                CommentModel newCom = new CommentModel
                {
                    CommentId = com.CommentId,
                    Text = com.Text,
                    PostPostId = com.PostPostId,
                    Post = postModel
                };
                postModel.Comments.Coments.Add(newCom);
            }

            return await Task.FromResult(postModel);


        }

        public override async Task<PostInt> DeletePost(PostInt request, ServerCallContext context)
        {
            Post post = new Post();
            return await Task.FromResult(new PostInt { Id = post.DeletePost(request.Id) });
        }

        public override async Task<PostModel> GetPostById(PostInt request, ServerCallContext context)
        {
            Post post = new Post();
            post = post.GetPostById(request.Id);

            PostModel postModel = new PostModel {
                PostId = post.PostId,
                Description = post.Description,
                Domain = post.Domain,
                Date = post.Date.ToString()
            };


            foreach (Comment com in post.Comments)
            {
                CommentModel newCom = new CommentModel
                {
                    CommentId = com.CommentId,
                    Text = com.Text,
                    PostPostId = com.PostPostId,
                    Post = postModel
                };
                postModel.Comments.Coments.Add(newCom);
            }

            return await Task.FromResult(postModel);

        }



    }
}

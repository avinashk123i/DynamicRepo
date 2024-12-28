using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Behavior.Mediator
{
    public class Request : IRequest<MyResponse>
    {

        public string Message { get; set; }

    }


    public class MyResponse
    {
        public string Result { get; set; }
    }


    public class RequestHandler : IRequestHandler<Request, MyResponse>
    {
        public Task<MyResponse> Handle(Request request, CancellationToken cancellationToken)
        {

            return Task.FromResult(new MyResponse { Result = $"Handled: {request.Message}" });
        }
    }
}

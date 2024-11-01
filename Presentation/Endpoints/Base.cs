using FastEndpoints;

namespace Presentation.Endpoints
{
    public class Base : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Get("");
            AllowAnonymous();
        }
        public override Task HandleAsync(CancellationToken ct)
        {
            return null;
        }
    }
}

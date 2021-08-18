using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    public class $safeitemname$ : IRequestHandler<$fileinputname$Command, $fileinputname$Response>
    {
        public Task<$fileinputname$Response> Handle($fileinputname$Command request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

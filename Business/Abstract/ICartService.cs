﻿using Core.Business.Abstract;
using Core.Utils;
using Entities.Surrogate.Request;
using Entities.Surrogate.Response;

namespace Business.Abstract
{
    public interface ICartService : IService<CartRequest, CartResponse>
    {
        IResult DeleteCartItem(int cartItemId);
    }
}

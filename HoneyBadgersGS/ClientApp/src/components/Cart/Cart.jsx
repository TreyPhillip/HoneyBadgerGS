﻿import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import './Cart.css';
import CartDetail from './CartDetail';

export class Cart extends Component {
    constructor(props) {
        super(props);
        this.state = {
            cartItems: JSON.parse(sessionStorage.getItem("cart")) 
        }
    }  
    render() {
        
        return (
            <div>
                <h1>Shopping Cart</h1><br/><br/>

                <div class="shopping-cart">

                    <div class="column-labels">
                        <label className="product-image">Image</label>
                        <label className="product-details">Product</label>
                        <label className="product-price">Price</label>
                        <label className="product-quantity">Quantity</label>
                        <label className="product-removal">Remove</label>
                        <label className="product-line-price">Total</label>
                    </div>

                    {this.state.cartItems && this.state.cartItems.map(item =>
                        (<CartDetail key={item.itemID} itemID={item.itemID} itemImage={item.itemImage} itemName={item.itemName} price={item.price} quantity={item.quantity} total={item.total}/>))}
      
                    <Link to="/Checkout">
                        <button className="checkout">Checkout</button>
                    </Link>
                </div>
            </div>
        )
    }
}
   
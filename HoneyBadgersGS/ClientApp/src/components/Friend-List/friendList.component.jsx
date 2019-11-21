import React, { Component } from "react";
import axios from "axios";

import "./friendList.component.css";

export class friendList extends React.Component {
  constructor(props) {
    super(props);
    this.switch = this.switch.bind(this);
    this.handleChange = this.handleChange.bind(this);
    this.state = {
      //when true, display frinds list, elsedisplay account list
      view: true,
      accounts: [],
      friendships: [],
      filteredAccounts: []
    };
  }

  //talks to the api in order to get the games from the database.
  componentDidMount() {
    axios
      .get("https://localhost:5001/api/Accounts/getaccounts")
      .then(res => {
        const accounts = res.data;
        this.setState({ accounts });
        this.setState({ filteredAccounts: this.state.accounts });
        console.log(res.data);
      })
      .catch(error => {
        if (error.response) {
          console.log(error.response.data);
        }
      });

    axios
      .get("https://localhost:5001/api/Friends/getfriends")
      .then(res => {
        const friendships = res.data;
        this.setState({ friendships });
        this.setState({ friendList: this.state.friendships });
        console.log(res.data);
      })
      .catch(error => {
        if (error.response) {
          console.log(error.response.data);
        }
      });

    // var friends = [{ UserName: "Jacob" }, { UserName: "Sean" }];
    // this.setState({ friendList: friends });
  }

  componentWillReceiveProps(nextProps) {
    this.setState({
      filteredAccounts: nextProps.items
    });
  }

  handleChange(e) {
    let currentList = [];
    let newList = [];

    if (e.target.value !== "") {
      currentList = this.state.accounts;

      newList = currentList.filter(item => {
        const lc = item.UserName.toString().toLowerCase();
        const filter = e.target.value.toLowerCase();

        return lc.includes(filter);
      });
    } else {
      newList = this.state.accounts;
    }
    this.setState({
      filteredAccounts: newList
    });
  }

  switch() {
    this.setState(prevState => ({
      view: !prevState.view
    }));
  }

  render() {
    if (this.state.view === true) {
      return (
        <div>
          <div>
            <h1>Friends List</h1>
            <button onClick={this.switch}>Add Friend</button>
            <div class="frinds-list">
              <div class="column-labels"></div>
              {this.state.friendships.map((friend, i) => {
                return (
                  <div>
                    <div class="product">
                      <div class="product-details">
                        <div class="product-title">
                          {friend.UserName} <button>remove</button>
                        </div>
                      </div>
                    </div>
                  </div>
                );
              })}
            </div>
          </div>
        </div>
      );
    } else if (this.state.view === false) {
      return (
        <div>
          <div>
            <h1>Add Friends</h1>
            <button onClick={this.switch}>Back</button>
            <input
              type="text"
              className="input"
              placeholder="search users..."
              onChange={this.handleChange}
            />
            <ul></ul>
            <div class="user-list">
              <div class="column-labels"></div>
              {this.state.filteredAccounts.map((account, i) => {
                return (
                  <div>
                    <div class="user">
                      <div class="user-details">
                        <div class="user-name">
                          {account.userName} <button>add</button>
                        </div>
                      </div>
                    </div>
                  </div>
                );
              })}
            </div>
          </div>
        </div>
      );
    }
  }
}

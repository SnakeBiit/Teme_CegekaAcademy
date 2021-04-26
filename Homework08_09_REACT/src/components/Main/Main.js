import React, { Component } from 'react';
import { Switch, Route } from "react-router-dom";
import  AlbumList   from '../Album/AlbumList';
import  PhotoList  from '../Photo/PhotoList';
import Login from '../Login';
import { Message } from 'semantic-ui-react'

class Main extends React.Component
{
    
    renderError(){
        return(
            <Message
                icon = "warning cicle"
                header= "Ups... Page not found"
                content = "Our engineers didn't fount what you are looking for, please try again!"
            />
        );
    }
    render(){
        
        return(
            <Switch>
                <Route exact path="/" component={Login} />
                <Route path="/albums" component={AlbumList} />
                <Route path="/photos" component={PhotoList} />
                
                <Route path="/login" component={Login} />
                <Route render = {this.renderError} />
            </Switch>
        );
    }
    
}
export default Main;

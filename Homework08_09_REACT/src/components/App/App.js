import React from 'react';
import Main from '../Main';
import Nav from '../Nav';
import 'semantic-ui-css/semantic.min.css';
import { BrowserRouter } from "react-router-dom";
import { Provider } from 'react-redux'
import reducer from '../../reducers/index'
import  configureStore  from '../../store/configureStore';

const store = configureStore(reducer);
const App = () => {
  return (
    <Provider store = {store} > 
      <BrowserRouter>
        <div>
          <Nav />
          <Main />
      </div> 
      </BrowserRouter>
    </Provider>
  );
}

export default App;

import React from 'react';
import ProtoTypes from 'prop-types';
import { Grid, Segment } from 'semantic-ui-react';
import './StatusBar.css'
import { GridColumn } from 'semantic-ui-react';

const StatusBar = (props) => {
    return(
        <Grid columns={2} className='status-bar'>
            <Grid.Column>
                <Segment basic >
                    {props.title}
                </Segment>
            </Grid.Column>
            <GridColumn textAlign='right'>
                 <Segment basic >
                    {props.children}
                </Segment>
            </GridColumn>
        </Grid>
    );
}
StatusBar.protoTypes ={
    title: ProtoTypes.string.isRequired,
}
export default StatusBar;
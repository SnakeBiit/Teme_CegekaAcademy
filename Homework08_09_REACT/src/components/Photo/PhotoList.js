import React from 'react';
import ProtoTypes from 'prop-types';
import Photo  from './Photo';
import PhotoForm  from './PhotoForm'
import { Card } from 'semantic-ui-react';
import StatusBar from '../StatusBar';
import { DeleteButton } from '../Common';
import { connect } from 'react-redux';
import * as photoActions from '../../actions/photoActions'
import config from '../../store/configureStore'

const PhotoList = (props) => {
    const{ photos } = props;

    const renderPhotos= () => {
        const { deletePhoto } = props;
        return(
            Object.keys(photos).map(key =>{
                
                const photo = photos[key];
                
                return(
                    <Photo 
                        key = {key}
                        photo = {photo}
                        >
                        

                        <PhotoForm
                            formType ='Edit'
                            index = {key}
                             photo = {photo}
                          
                        />

                        <DeleteButton
                            index = {key}
                            objectName = {photo.title}
                            deleteObject = {deletePhoto}
                            />
                    </Photo>
                );
            })
        );
    }
    return (
        <div>
            <StatusBar title= {`${Object.keys(photos).length} Photo(s) total`}>
                <PhotoForm
                    formType='New'
                    photos={photos}
                    
                    />
            </StatusBar>
            <Card.Group itemsPerRow={4} doubling >
                {renderPhotos()}
            </Card.Group>
        </div>
    );    
}

PhotoList.protoTypes ={
    title: ProtoTypes.string.isRequired,
}

const mapStateToProps = (state) => {
    return {
        albums: state.albums,
        photos: state.photos,
    }
}
function mapDispatchToProps(dispatch){
    return {
        deletePhoto: key => dispatch(photoActions.deletePhoto(key)),
    }
}
export  default connect(mapStateToProps, mapDispatchToProps)(PhotoList);
export {PhotoList}

import React from 'react';
import PropTypes from 'prop-types';
import { Card , Image,  Button} from 'semantic-ui-react';
import './Photo.css'


const Photo = (props) => {
    const { photo, photos } = props;

    return(
        
        <Card>

            <Image src={photo.url}/>  

            <Card.Content className='header'>
                <Card.Header>
                    {photo.title}
                </Card.Header>

            </Card.Content>
            
            <Card.Content>
                <Card.Description as='p'>
                    {photo.description}
                </Card.Description>
            </Card.Content>

            <Button.Group basic attached = 'bottom'>
                {props.children}
            </Button.Group>
        </Card>
    );
}
Photo.propTypes = {
    photo: PropTypes.object.isRequired,
  
}
export default Photo;

